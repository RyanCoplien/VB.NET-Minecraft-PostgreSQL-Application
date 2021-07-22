-- Authors: Ryan Coplien, Kasey Tippelt, Brandon Conway
-- Course: CS 3630
-- Project: Final Course Project

-- Create all tables. Uses triggers for created_at stuff. Deleted boolean so that we don't actually delete data
CREATE TABLE blocks
(
	id integer GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	name varchar(255) NOT NULL,
	created_at timestamp with time zone NOT NULL DEFAULT current_timestamp,
	updated_at timestamp with time zone NOT NULL DEFAULT current_timestamp,
	deleted boolean NOT NULL DEFAULT FALSE,
	UNIQUE (name)
);
CREATE TABLE mob_types
(
	id integer GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	name varchar(255) NOT NULL,
	created_at timestamp with time zone NOT NULL DEFAULT current_timestamp,
	updated_at timestamp with time zone NOT NULL DEFAULT current_timestamp,
	deleted boolean NOT NULL DEFAULT FALSE,
	UNIQUE (name)
);
CREATE TABLE mob_aggressions
(
	id integer GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	name varchar(255) NOT NULL,
	created_at timestamp with time zone NOT NULL DEFAULT current_timestamp,
	updated_at timestamp with time zone NOT NULL DEFAULT current_timestamp,
	deleted boolean NOT NULL DEFAULT FALSE,
	UNIQUE (name)
);
CREATE TABLE biome_types
(
	id integer GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	name varchar(255) NOT NULL,
	created_at timestamp with time zone NOT NULL DEFAULT current_timestamp,
	updated_at timestamp with time zone NOT NULL DEFAULT current_timestamp,
	deleted boolean NOT NULL DEFAULT FALSE,
	UNIQUE (name)
);
CREATE TABLE items
(
	id integer GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	name varchar(255) NOT NULL,
	created_at timestamp with time zone NOT NULL DEFAULT current_timestamp,
	updated_at timestamp with time zone NOT NULL DEFAULT current_timestamp,
	deleted boolean NOT NULL DEFAULT FALSE,
	UNIQUE (name)
);
CREATE TABLE biomes
(
	id integer GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	name varchar(255) NOT NULL,
	temperature double precision NOT NULL,
	biome_type_id integer NOT NULL REFERENCES biome_types(id),
	created_at timestamp with time zone NOT NULL DEFAULT current_timestamp,
	updated_at timestamp with time zone NOT NULL DEFAULT current_timestamp,
	deleted boolean NOT NULL DEFAULT FALSE,
	UNIQUE (name, biome_type_id)
);
CREATE TABLE biome_blocks
(
	id integer GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	biome_id integer NOT NULL REFERENCES biomes(id),
	block_id integer NOT NULL REFERENCES blocks(id),
	created_at timestamp with time zone NOT NULL DEFAULT current_timestamp,
	updated_at timestamp with time zone NOT NULL DEFAULT current_timestamp,
	deleted boolean NOT NULL DEFAULT FALSE,
	UNIQUE (biome_id, block_id)
	
);
CREATE TABLE mobs
(
	id integer GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	name varchar(255) NOT NULL,
	health integer NOT NULL,
	can_be_bred boolean NOT NULL DEFAULT FALSE,
	mob_type_id integer NOT NULL REFERENCES mob_types(id),
	mob_aggression_id integer NOT NULL REFERENCES mob_aggressions(id),
	created_at timestamp with time zone NOT NULL DEFAULT current_timestamp,
	updated_at timestamp with time zone NOT NULL DEFAULT current_timestamp,
	deleted boolean NOT NULL DEFAULT FALSE,
	UNIQUE (name, mob_type_id,mob_aggression_id),
	CHECK (health > 0)
);
CREATE TABLE biome_mobs
(
	id integer GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	biome_id integer NOT NULL REFERENCES biomes(id),
	mob_id integer NOT NULL REFERENCES mobs(id),
	created_at timestamp with time zone NOT NULL DEFAULT current_timestamp,
	updated_at timestamp with time zone NOT NULL DEFAULT current_timestamp,
	deleted boolean NOT NULL DEFAULT FALSE,
	UNIQUE (biome_id, mob_id)
);
CREATE TABLE mob_item_drops
(
	id integer GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	mob_id integer NOT NULL REFERENCES mobs(id),
	drop_item_id integer NOT NULL REFERENCES items(id),
	created_at timestamp with time zone NOT NULL DEFAULT current_timestamp,
	updated_at timestamp with time zone NOT NULL DEFAULT current_timestamp,
	deleted boolean NOT NULL DEFAULT FALSE,
	UNIQUE (mob_id, drop_item_id)
);
CREATE TABLE brewing_recipies
(
	id integer GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	potion_item_id integer NOT NULL REFERENCES items(id),
	ingredient_item_id integer NOT NULL REFERENCES items(id),
	created_at timestamp with time zone NOT NULL DEFAULT current_timestamp,
	updated_at timestamp with time zone NOT NULL DEFAULT current_timestamp,
	deleted boolean NOT NULL DEFAULT FALSE,
	UNIQUE (potion_item_id, ingredient_item_id)
);
CREATE TABLE mob_breeding_items
(
	id integer GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	mob_id integer NOT NULL REFERENCES mobs(id),
	breeding_item_id integer NOT NULL REFERENCES items(id),
	created_at timestamp with time zone NOT NULL DEFAULT current_timestamp,
	updated_at timestamp with time zone NOT NULL DEFAULT current_timestamp,
	deleted boolean NOT NULL DEFAULT FALSE,
	UNIQUE (mob_id, breeding_item_id)
);

-- Function to update the updated_at column when there is an update to it
CREATE OR REPLACE FUNCTION set_updated_at()
	RETURNS trigger AS
$BODY$
BEGIN
	NEW.updated_at = NOW();
	RETURN NEW;
END;
$BODY$
LANGUAGE plpgsql;

-- Triggers to set updated_at columns upon each update of role
CREATE TRIGGER update_blocks
BEFORE UPDATE ON blocks
FOR EACH ROW
EXECUTE PROCEDURE set_updated_at();

CREATE TRIGGER update_biomes
BEFORE UPDATE ON biomes
FOR EACH ROW
EXECUTE PROCEDURE set_updated_at();

CREATE TRIGGER update_biome_blocks
BEFORE UPDATE ON biome_blocks
FOR EACH ROW
EXECUTE PROCEDURE set_updated_at();

CREATE TRIGGER update_biome_mods
BEFORE UPDATE ON biome_mobs
FOR EACH ROW
EXECUTE PROCEDURE set_updated_at();

CREATE TRIGGER update_mobs
BEFORE UPDATE ON mobs
FOR EACH ROW
EXECUTE PROCEDURE set_updated_at();

CREATE TRIGGER update_mob_aggressions
BEFORE UPDATE ON mob_aggressions
FOR EACH ROW
EXECUTE PROCEDURE set_updated_at();

CREATE TRIGGER update_mob_types
BEFORE UPDATE ON mob_types
FOR EACH ROW
EXECUTE PROCEDURE set_updated_at();

CREATE TRIGGER update_mob_item_drops
BEFORE UPDATE ON mob_item_drops
FOR EACH ROW
EXECUTE PROCEDURE set_updated_at();

CREATE TRIGGER update_items
BEFORE UPDATE ON items
FOR EACH ROW
EXECUTE PROCEDURE set_updated_at();

CREATE TRIGGER update_brewing_recipies
BEFORE UPDATE ON brewing_recipies
FOR EACH ROW
EXECUTE PROCEDURE set_updated_at();

CREATE TRIGGER update_mob_breeding_items
BEFORE UPDATE ON mob_breeding_items
FOR EACH ROW
EXECUTE PROCEDURE set_updated_at();

CREATE TRIGGER update_biome_types
BEFORE UPDATE ON biome_types
FOR EACH ROW
EXECUTE PROCEDURE set_updated_at();

-- Insert statements created to prepopulate database
-- biome_types INSERT
INSERT INTO biome_types(name) VALUES ('Snowy');
INSERT INTO biome_types(name) VALUES ('Cold');
INSERT INTO biome_types(name) VALUES ('Temperate/Lush');
INSERT INTO biome_types(name) VALUES ('The End');
INSERT INTO biome_types(name) VALUES ('Dry/Warm');
INSERT INTO biome_types(name) VALUES ('Nether');
INSERT INTO biome_types(name) VALUES ('Ocean');
INSERT INTO biome_types(name) VALUES ('Neutral');
INSERT INTO biome_types(name) VALUES ('Unused');
-- mob_types INSERT
INSERT INTO mob_types(name) VALUES ('Animal');
INSERT INTO mob_types(name) VALUES ('Water-Based');
INSERT INTO mob_types(name) VALUES ('Arthopods');
INSERT INTO mob_types(name) VALUES ('Undead');
INSERT INTO mob_types(name) VALUES ('Illagers');
INSERT INTO mob_types(name) VALUES ('Undefined');
-- mob_aggressions INSERT
INSERT INTO mob_aggressions(name) VALUES ('Passive');
INSERT INTO mob_aggressions(name) VALUES ('Neutral');
INSERT INTO mob_aggressions(name) VALUES ('Hostile');
INSERT INTO mob_aggressions(name) VALUES ('Boss');
-- blocks INSERT
INSERT INTO blocks(name) VALUES ('Acacia Bark');
INSERT INTO blocks(name) VALUES ('Acacia Bark Slab');
INSERT INTO blocks(name) VALUES ('Acacia Bark Stair');
INSERT INTO blocks(name) VALUES ('Acacia Button');
INSERT INTO blocks(name) VALUES ('Acacia Fence');
INSERT INTO blocks(name) VALUES ('Acacia Fence Gate');
INSERT INTO blocks(name) VALUES ('Acacia Leaves');
INSERT INTO blocks(name) VALUES ('Acacia');
INSERT INTO blocks(name) VALUES ('Acacia Plank');
INSERT INTO blocks(name) VALUES ('Acacia Pressure Plate');
INSERT INTO blocks(name) VALUES ('Acacia Sapling Flower Pot');
INSERT INTO blocks(name) VALUES ('Acacia Sapling');
INSERT INTO blocks(name) VALUES ('Acacia Slab');
INSERT INTO blocks(name) VALUES ('Acacia Stair');
INSERT INTO blocks(name) VALUES ('Acacia Trapdoor');
INSERT INTO blocks(name) VALUES ('Activator Rail');
INSERT INTO blocks(name) VALUES ('Allium Flower Pot');
INSERT INTO blocks(name) VALUES ('Allium');
INSERT INTO blocks(name) VALUES ('Andesite');
INSERT INTO blocks(name) VALUES ('Andesite Slab');
INSERT INTO blocks(name) VALUES ('Andesite Stair');
INSERT INTO blocks(name) VALUES ('Andesite Wall');
INSERT INTO blocks(name) VALUES ('Anvil');
INSERT INTO blocks(name) VALUES ('Azure Bluet Flower Pot');
INSERT INTO blocks(name) VALUES ('Azure Bluet');
INSERT INTO blocks(name) VALUES ('Barrier');
INSERT INTO blocks(name) VALUES ('Bed Red');
INSERT INTO blocks(name) VALUES ('Bedrock');
INSERT INTO blocks(name) VALUES ('Bell');
INSERT INTO blocks(name) VALUES ('Birch Bark');
INSERT INTO blocks(name) VALUES ('Birch Bark Slab');
INSERT INTO blocks(name) VALUES ('Birch Bark Stair');
INSERT INTO blocks(name) VALUES ('Birch Button');
INSERT INTO blocks(name) VALUES ('Birch Door');
INSERT INTO blocks(name) VALUES ('Birch Fence');
INSERT INTO blocks(name) VALUES ('Birch Fence Gate');
INSERT INTO blocks(name) VALUES ('Birch Leaves');
INSERT INTO blocks(name) VALUES ('Birch');
INSERT INTO blocks(name) VALUES ('Birch Plank');
INSERT INTO blocks(name) VALUES ('Birch Pressure Plate');
INSERT INTO blocks(name) VALUES ('Birch Sapling Flower Pot');
INSERT INTO blocks(name) VALUES ('Birch Sapling');
INSERT INTO blocks(name) VALUES ('Birch Slab');
INSERT INTO blocks(name) VALUES ('Birch Stair');
INSERT INTO blocks(name) VALUES ('Birch Trapdoor');
INSERT INTO blocks(name) VALUES ('Black Bed');
INSERT INTO blocks(name) VALUES ('Black Carpet');
INSERT INTO blocks(name) VALUES ('Black Concrete');
INSERT INTO blocks(name) VALUES ('Black Concrete Powder');
INSERT INTO blocks(name) VALUES ('Black Concrete Slab');
INSERT INTO blocks(name) VALUES ('Black Concrete Stair');
INSERT INTO blocks(name) VALUES ('Black Glazed Terracotta');
INSERT INTO blocks(name) VALUES ('Black Shulker Box');
INSERT INTO blocks(name) VALUES ('Black Stained Glass');
INSERT INTO blocks(name) VALUES ('Black Stained Glass Pane');
INSERT INTO blocks(name) VALUES ('Black Terracotta');
INSERT INTO blocks(name) VALUES ('Black Wool');
INSERT INTO blocks(name) VALUES ('Blue Bed');
INSERT INTO blocks(name) VALUES ('Blue Carpet');
INSERT INTO blocks(name) VALUES ('Blue Concrete');
INSERT INTO blocks(name) VALUES ('Blue Concrete Powder');
INSERT INTO blocks(name) VALUES ('Blue Concrete Slab');
INSERT INTO blocks(name) VALUES ('Blue Concrete Stair');
INSERT INTO blocks(name) VALUES ('Blue Glazed Terracotta');
INSERT INTO blocks(name) VALUES ('Blue Orchid Flower Pot');
INSERT INTO blocks(name) VALUES ('Blue Orchid');
INSERT INTO blocks(name) VALUES ('Blue Shulker Box');
INSERT INTO blocks(name) VALUES ('Blue Stained Glass');
INSERT INTO blocks(name) VALUES ('Blue Stained Glass Pane');
INSERT INTO blocks(name) VALUES ('Blue Terracotta');
INSERT INTO blocks(name) VALUES ('Blue Wool');
INSERT INTO blocks(name) VALUES ('Bone Block');
INSERT INTO blocks(name) VALUES ('Bookshelf');
INSERT INTO blocks(name) VALUES ('Brewing Stand');
INSERT INTO blocks(name) VALUES ('Brick Block');
INSERT INTO blocks(name) VALUES ('Brick Slab');
INSERT INTO blocks(name) VALUES ('Brick Stair');
INSERT INTO blocks(name) VALUES ('Brick Wall');
INSERT INTO blocks(name) VALUES ('Brown Bed');
INSERT INTO blocks(name) VALUES ('Brown Carpet');
INSERT INTO blocks(name) VALUES ('Brown Concrete');
INSERT INTO blocks(name) VALUES ('Brown Concrete Powder');
INSERT INTO blocks(name) VALUES ('Brown Concrete Slab');
INSERT INTO blocks(name) VALUES ('Brown Concrete Stair');
INSERT INTO blocks(name) VALUES ('Brown Glazed Terracotta');
INSERT INTO blocks(name) VALUES ('Brown Mushroom');
INSERT INTO blocks(name) VALUES ('Brown Mushroom Flower Pot');
INSERT INTO blocks(name) VALUES ('Brown Shulker Box');
INSERT INTO blocks(name) VALUES ('Brown Stained Glass');
INSERT INTO blocks(name) VALUES ('Brown Stained Glass Pane');
INSERT INTO blocks(name) VALUES ('Brown Terracotta');
INSERT INTO blocks(name) VALUES ('Brown Wool');
INSERT INTO blocks(name) VALUES ('Burning Furnace');
INSERT INTO blocks(name) VALUES ('Cactus');
INSERT INTO blocks(name) VALUES ('Cactus Flower Pot');
INSERT INTO blocks(name) VALUES ('Cake');
INSERT INTO blocks(name) VALUES ('Cauldron');
INSERT INTO blocks(name) VALUES ('Chest');
INSERT INTO blocks(name) VALUES ('Chiseled Quartz Block');
INSERT INTO blocks(name) VALUES ('Chiseled Red Sandstone');
INSERT INTO blocks(name) VALUES ('Chorus Flower');
INSERT INTO blocks(name) VALUES ('Chorus Plant Stem');
INSERT INTO blocks(name) VALUES ('Clay');
INSERT INTO blocks(name) VALUES ('Coal Block');
INSERT INTO blocks(name) VALUES ('Coal Ore');
INSERT INTO blocks(name) VALUES ('Coarse Dirt');
INSERT INTO blocks(name) VALUES ('Cobblestone');
INSERT INTO blocks(name) VALUES ('Cobblestone Slab');
INSERT INTO blocks(name) VALUES ('Cobblestone Stair');
INSERT INTO blocks(name) VALUES ('Cobblestone Wall');
INSERT INTO blocks(name) VALUES ('Cobweb');
INSERT INTO blocks(name) VALUES ('Command Block');
INSERT INTO blocks(name) VALUES ('Cracked Stone Brick Slab');
INSERT INTO blocks(name) VALUES ('Cracked Stone Brick Stair');
INSERT INTO blocks(name) VALUES ('Crafting Table');
INSERT INTO blocks(name) VALUES ('Creeper Head');
INSERT INTO blocks(name) VALUES ('Cut Red Sandstone');
INSERT INTO blocks(name) VALUES ('Cut Sandstone');
INSERT INTO blocks(name) VALUES ('Cyan Bed');
INSERT INTO blocks(name) VALUES ('Cyan Carpet');
INSERT INTO blocks(name) VALUES ('Cyan Concrete');
INSERT INTO blocks(name) VALUES ('Cyan Concrete Powder');
INSERT INTO blocks(name) VALUES ('Cyan Concrete Slab');
INSERT INTO blocks(name) VALUES ('Cyan Concrete Stair');
INSERT INTO blocks(name) VALUES ('Cyan Glazed Terracotta');
INSERT INTO blocks(name) VALUES ('Cyan Shulker Box');
INSERT INTO blocks(name) VALUES ('Cyan Stained Glass');
INSERT INTO blocks(name) VALUES ('Cyan Stained Glass Pane');
INSERT INTO blocks(name) VALUES ('Cyan Terracotta');
INSERT INTO blocks(name) VALUES ('Cyan Wool');
INSERT INTO blocks(name) VALUES ('Dandelion');
INSERT INTO blocks(name) VALUES ('Dandelion Flower Pot');
INSERT INTO blocks(name) VALUES ('Dark Oak');
INSERT INTO blocks(name) VALUES ('Dark Oak Bark');
INSERT INTO blocks(name) VALUES ('Dark Oak Bark Slab');
INSERT INTO blocks(name) VALUES ('Dark Oak Bark Stair');
INSERT INTO blocks(name) VALUES ('Dark Oak Button');
INSERT INTO blocks(name) VALUES ('Dark Oak Fence');
INSERT INTO blocks(name) VALUES ('Dark Oak Fence Gate');
INSERT INTO blocks(name) VALUES ('Dark Oak Leaves');
INSERT INTO blocks(name) VALUES ('Dark Oak Plank');
INSERT INTO blocks(name) VALUES ('Dark Oak Pressure Plate');
INSERT INTO blocks(name) VALUES ('Dark Oak Sapling Flower Pot');
INSERT INTO blocks(name) VALUES ('Dark Oak Sapling');
INSERT INTO blocks(name) VALUES ('Dark Oak Slab');
INSERT INTO blocks(name) VALUES ('Dark Oak Stair');
INSERT INTO blocks(name) VALUES ('Dark Oak Trapdoor');
INSERT INTO blocks(name) VALUES ('Dark Prismarine Slab');
INSERT INTO blocks(name) VALUES ('Dark Prismarine Stair');
INSERT INTO blocks(name) VALUES ('Daylight Sensor');
INSERT INTO blocks(name) VALUES ('Dead Bush');
INSERT INTO blocks(name) VALUES ('Dead Bush Flower Pot');
INSERT INTO blocks(name) VALUES ('Dead Chorus Flower');
INSERT INTO blocks(name) VALUES ('Detector Rail');
INSERT INTO blocks(name) VALUES ('Diamond Block');
INSERT INTO blocks(name) VALUES ('Diamond Ore');
INSERT INTO blocks(name) VALUES ('Diorite');
INSERT INTO blocks(name) VALUES ('Diorite Slab');
INSERT INTO blocks(name) VALUES ('Diorite Stair');
INSERT INTO blocks(name) VALUES ('Diorite Wall');
INSERT INTO blocks(name) VALUES ('Dirt');
INSERT INTO blocks(name) VALUES ('Disabled Hopper');
INSERT INTO blocks(name) VALUES ('Disabled Side Hopper');
INSERT INTO blocks(name) VALUES ('Dispenser');
INSERT INTO blocks(name) VALUES ('Double Acacia Bark Slab');
INSERT INTO blocks(name) VALUES ('Double Acacia Slab');
INSERT INTO blocks(name) VALUES ('Double Andesite Slab');
INSERT INTO blocks(name) VALUES ('Double Birch Bark Slab');
INSERT INTO blocks(name) VALUES ('Double Birch Slab');
INSERT INTO blocks(name) VALUES ('Double Black Concrete Slab');
INSERT INTO blocks(name) VALUES ('Double Blue Concrete Slab');
INSERT INTO blocks(name) VALUES ('Double Brick Slab');
INSERT INTO blocks(name) VALUES ('Double Brown Concrete Slab');
INSERT INTO blocks(name) VALUES ('Double Cobblestone Slab');
INSERT INTO blocks(name) VALUES ('Double Cracked Stone Brick Slab');
INSERT INTO blocks(name) VALUES ('Double Cyan Concrete Slab');
INSERT INTO blocks(name) VALUES ('Double Dark Oak Bark Slab');
INSERT INTO blocks(name) VALUES ('Double Dark Oak Slab');
INSERT INTO blocks(name) VALUES ('Double Dark Prismarine Slab');
INSERT INTO blocks(name) VALUES ('Double Diorite Slab');
INSERT INTO blocks(name) VALUES ('Double End Stone Brick Slab');
INSERT INTO blocks(name) VALUES ('Double Gold Block Slab');
INSERT INTO blocks(name) VALUES ('Double Granite Slab');
INSERT INTO blocks(name) VALUES ('Double Green Concrete Slab');
INSERT INTO blocks(name) VALUES ('Double Grey Concrete Slab');
INSERT INTO blocks(name) VALUES ('Double Iron Block Slab');
INSERT INTO blocks(name) VALUES ('Double Jungle Bark Slab');
INSERT INTO blocks(name) VALUES ('Double Jungle Slab');
INSERT INTO blocks(name) VALUES ('Double Lapis Lazuli Slab');
INSERT INTO blocks(name) VALUES ('Double Light Blue Concrete Slab');
INSERT INTO blocks(name) VALUES ('Double Light Grey Concrete Slab');
INSERT INTO blocks(name) VALUES ('Double Lime Concrete Slab');
INSERT INTO blocks(name) VALUES ('Double Magenta Concrete Slab');
INSERT INTO blocks(name) VALUES ('Double Mossy Stone Brick Slab');
INSERT INTO blocks(name) VALUES ('Double Mossy Stone Slab');
INSERT INTO blocks(name) VALUES ('Double Nether Brick Slab');
INSERT INTO blocks(name) VALUES ('Double Oak Bark Slab');
INSERT INTO blocks(name) VALUES ('Double Oak Slab');
INSERT INTO blocks(name) VALUES ('Double Orange Concrete Slab');
INSERT INTO blocks(name) VALUES ('Double Pink Concrete Slab');
INSERT INTO blocks(name) VALUES ('Double Polished Andesite Slab');
INSERT INTO blocks(name) VALUES ('Double Polished Diorite Slab');
INSERT INTO blocks(name) VALUES ('Double Polished Granite Slab');
INSERT INTO blocks(name) VALUES ('Double Polished Stone Slab');
INSERT INTO blocks(name) VALUES ('Double Prismarine Brick Slab');
INSERT INTO blocks(name) VALUES ('Double Prismarine Slab');
INSERT INTO blocks(name) VALUES ('Double Purple Concrete Slab');
INSERT INTO blocks(name) VALUES ('Double Purpur Slab');
INSERT INTO blocks(name) VALUES ('Double Quartz Slab');
INSERT INTO blocks(name) VALUES ('Double Red Concrete Slab');
INSERT INTO blocks(name) VALUES ('Double Red Nether Brick Slab');
INSERT INTO blocks(name) VALUES ('Double Red Sandstone Slab');
INSERT INTO blocks(name) VALUES ('Double Sandstone Slab');
INSERT INTO blocks(name) VALUES ('Double Smooth Quartz Slab');
INSERT INTO blocks(name) VALUES ('Double Smooth Red Sandstone Slab');
INSERT INTO blocks(name) VALUES ('Double Smooth Sandstone Slab');
INSERT INTO blocks(name) VALUES ('Double Spruce Bark Slab');
INSERT INTO blocks(name) VALUES ('Double Spruce Slab');
INSERT INTO blocks(name) VALUES ('Double Stone Brick Slab');
INSERT INTO blocks(name) VALUES ('Double Stone Slab');
INSERT INTO blocks(name) VALUES ('Double Tallgrass');
INSERT INTO blocks(name) VALUES ('Double White Concrete Slab');
INSERT INTO blocks(name) VALUES ('Double Yellow Concrete Slab');
INSERT INTO blocks(name) VALUES ('Dragon Egg');
INSERT INTO blocks(name) VALUES ('Dropper');
INSERT INTO blocks(name) VALUES ('Emerald Block');
INSERT INTO blocks(name) VALUES ('Emerald Ore');
INSERT INTO blocks(name) VALUES ('Enchanting Table');
INSERT INTO blocks(name) VALUES ('Ender Chest');
INSERT INTO blocks(name) VALUES ('End Portal');
INSERT INTO blocks(name) VALUES ('End Portal Frame');
INSERT INTO blocks(name) VALUES ('End Portal Frame with Eye of Ender');
INSERT INTO blocks(name) VALUES ('End Rod');
INSERT INTO blocks(name) VALUES ('End Stone');
INSERT INTO blocks(name) VALUES ('End Stone Brick');
INSERT INTO blocks(name) VALUES ('End Stone Brick Slab');
INSERT INTO blocks(name) VALUES ('End Stone Brick Stair');
INSERT INTO blocks(name) VALUES ('End Stone Brick Wall');
INSERT INTO blocks(name) VALUES ('Eternal Fire');
INSERT INTO blocks(name) VALUES ('Faceless Pumpkin');
INSERT INTO blocks(name) VALUES ('Farmland');
INSERT INTO blocks(name) VALUES ('Fence');
INSERT INTO blocks(name) VALUES ('Fern Flower Pot');
INSERT INTO blocks(name) VALUES ('Fern');
INSERT INTO blocks(name) VALUES ('Fire');
INSERT INTO blocks(name) VALUES ('Flower Pot');
INSERT INTO blocks(name) VALUES ('Flowing Lava');
INSERT INTO blocks(name) VALUES ('Flowing Nether Lava');
INSERT INTO blocks(name) VALUES ('Flowing River Water');
INSERT INTO blocks(name) VALUES ('Flowing Water');
INSERT INTO blocks(name) VALUES ('Frosted Ice');
INSERT INTO blocks(name) VALUES ('Furnace');
INSERT INTO blocks(name) VALUES ('Glass');
INSERT INTO blocks(name) VALUES ('Glass Pane');
INSERT INTO blocks(name) VALUES ('Glowstone');
INSERT INTO blocks(name) VALUES ('Gold Block');
INSERT INTO blocks(name) VALUES ('Gold Block Slab');
INSERT INTO blocks(name) VALUES ('Gold Block Stair');
INSERT INTO blocks(name) VALUES ('Gold Ore');
INSERT INTO blocks(name) VALUES ('Granite');
INSERT INTO blocks(name) VALUES ('Granite Slab');
INSERT INTO blocks(name) VALUES ('Granite Stair');
INSERT INTO blocks(name) VALUES ('Granite Wall');
INSERT INTO blocks(name) VALUES ('Grass');
INSERT INTO blocks(name) VALUES ('Grass Block');
INSERT INTO blocks(name) VALUES ('Grass Dry');
INSERT INTO blocks(name) VALUES ('Grass Path');
INSERT INTO blocks(name) VALUES ('Gravel');
INSERT INTO blocks(name) VALUES ('Green Bed');
INSERT INTO blocks(name) VALUES ('Green Carpet');
INSERT INTO blocks(name) VALUES ('Green Concrete');
INSERT INTO blocks(name) VALUES ('Green Concrete Powder');
INSERT INTO blocks(name) VALUES ('Green Concrete Slab');
INSERT INTO blocks(name) VALUES ('Green Concrete Stair');
INSERT INTO blocks(name) VALUES ('Green Glazed Terracotta');
INSERT INTO blocks(name) VALUES ('Green Shulker Box');
INSERT INTO blocks(name) VALUES ('Green Stained Glass');
INSERT INTO blocks(name) VALUES ('Green Stained Glass Pane');
INSERT INTO blocks(name) VALUES ('Green Terracotta');
INSERT INTO blocks(name) VALUES ('Green Wool');
INSERT INTO blocks(name) VALUES ('Grey Bed');
INSERT INTO blocks(name) VALUES ('Grey Carpet');
INSERT INTO blocks(name) VALUES ('Grey Concrete');
INSERT INTO blocks(name) VALUES ('Grey Concrete Powder');
INSERT INTO blocks(name) VALUES ('Grey Concrete Slab');
INSERT INTO blocks(name) VALUES ('Grey Concrete Stair');
INSERT INTO blocks(name) VALUES ('Grey Glazed Terracotta');
INSERT INTO blocks(name) VALUES ('Grey Shulker Box');
INSERT INTO blocks(name) VALUES ('Grey Stained Glass');
INSERT INTO blocks(name) VALUES ('Grey Stained Glass Pane');
INSERT INTO blocks(name) VALUES ('Grey Terracotta');
INSERT INTO blocks(name) VALUES ('Grey Wool');
INSERT INTO blocks(name) VALUES ('Hay Bale');
INSERT INTO blocks(name) VALUES ('Hopper');
INSERT INTO blocks(name) VALUES ('Huge Brown Mushroom All-Faces Stem');
INSERT INTO blocks(name) VALUES ('Huge Brown Mushroom Block');
INSERT INTO blocks(name) VALUES ('Huge Brown Mushroom Stem');
INSERT INTO blocks(name) VALUES ('Huge Red Mushroom All-Faces Stem');
INSERT INTO blocks(name) VALUES ('Huge Red Mushroom Block');
INSERT INTO blocks(name) VALUES ('Huge Red Mushroom Stem');
INSERT INTO blocks(name) VALUES ('Human Head');
INSERT INTO blocks(name) VALUES ('Hydrated Farmland');
INSERT INTO blocks(name) VALUES ('Ice');
INSERT INTO blocks(name) VALUES ('Ice Slab');
INSERT INTO blocks(name) VALUES ('Ice Stair');
INSERT INTO blocks(name) VALUES ('Infested Chiseled Stone Brick');
INSERT INTO blocks(name) VALUES ('Infested Cobblestone');
INSERT INTO blocks(name) VALUES ('Infested Cracked Stone Brick');
INSERT INTO blocks(name) VALUES ('Infested Mossy Stone Brick');
INSERT INTO blocks(name) VALUES ('Infested Stone');
INSERT INTO blocks(name) VALUES ('Infested Stone Brick');
INSERT INTO blocks(name) VALUES ('Inverted Daylight Sensor');
INSERT INTO blocks(name) VALUES ('Iron Bar');
INSERT INTO blocks(name) VALUES ('Iron Block');
INSERT INTO blocks(name) VALUES ('Iron Block Slab');
INSERT INTO blocks(name) VALUES ('Iron Block Stair');
INSERT INTO blocks(name) VALUES ('Iron Door');
INSERT INTO blocks(name) VALUES ('Iron Ore');
INSERT INTO blocks(name) VALUES ('Iron Trapdoor');
INSERT INTO blocks(name) VALUES ('Item Frame');
INSERT INTO blocks(name) VALUES ('Jack o Lantern');
INSERT INTO blocks(name) VALUES ('Jukebox');
INSERT INTO blocks(name) VALUES ('Jungle Bark');
INSERT INTO blocks(name) VALUES ('Jungle Bark Slab');
INSERT INTO blocks(name) VALUES ('Jungle Bark Stair');
INSERT INTO blocks(name) VALUES ('Jungle Button');
INSERT INTO blocks(name) VALUES ('Jungle Fence');
INSERT INTO blocks(name) VALUES ('Jungle Fence Gate');
INSERT INTO blocks(name) VALUES ('Jungle Leaves');
INSERT INTO blocks(name) VALUES ('Jungle');
INSERT INTO blocks(name) VALUES ('Jungle Plank');
INSERT INTO blocks(name) VALUES ('Jungle Pressure Plate');
INSERT INTO blocks(name) VALUES ('Jungle Sapling Flower Pot');
INSERT INTO blocks(name) VALUES ('Jungle Sapling');
INSERT INTO blocks(name) VALUES ('Jungle Slab');
INSERT INTO blocks(name) VALUES ('Jungle Stair');
INSERT INTO blocks(name) VALUES ('Jungle Trapdoor');
INSERT INTO blocks(name) VALUES ('Ladder');
INSERT INTO blocks(name) VALUES ('Lapis Lazuli Block');
INSERT INTO blocks(name) VALUES ('Lapis Lazuli Ore');
INSERT INTO blocks(name) VALUES ('Lapis Lazuli Slab');
INSERT INTO blocks(name) VALUES ('Lapis Lazuli Stair');
INSERT INTO blocks(name) VALUES ('Large Fern');
INSERT INTO blocks(name) VALUES ('Lava Source');
INSERT INTO blocks(name) VALUES ('Leaves');
INSERT INTO blocks(name) VALUES ('Lever');
INSERT INTO blocks(name) VALUES ('Light Blue Bed');
INSERT INTO blocks(name) VALUES ('Light Blue Carpet');
INSERT INTO blocks(name) VALUES ('Light Blue Concrete');
INSERT INTO blocks(name) VALUES ('Light Blue Concrete Powder');
INSERT INTO blocks(name) VALUES ('Light Blue Concrete Slab');
INSERT INTO blocks(name) VALUES ('Light Blue Concrete Stair');
INSERT INTO blocks(name) VALUES ('Light Blue Glazed Terracotta');
INSERT INTO blocks(name) VALUES ('Light Blue Shulker Box');
INSERT INTO blocks(name) VALUES ('Light Blue Stained Glass');
INSERT INTO blocks(name) VALUES ('Light Blue Stained Glass Pane');
INSERT INTO blocks(name) VALUES ('Light Blue Terracotta');
INSERT INTO blocks(name) VALUES ('Light Blue Wool');
INSERT INTO blocks(name) VALUES ('Light Grey Bed');
INSERT INTO blocks(name) VALUES ('Light Grey Carpet');
INSERT INTO blocks(name) VALUES ('Light Grey Concrete');
INSERT INTO blocks(name) VALUES ('Light Grey Concrete Powder');
INSERT INTO blocks(name) VALUES ('Light Grey Concrete Slab');
INSERT INTO blocks(name) VALUES ('Light Grey Concrete Stair');
INSERT INTO blocks(name) VALUES ('Light Grey Glazed Terracotta');
INSERT INTO blocks(name) VALUES ('Light Grey Shulker Box');
INSERT INTO blocks(name) VALUES ('Light Grey Stained Glass');
INSERT INTO blocks(name) VALUES ('Light Grey Stained Glass Pane');
INSERT INTO blocks(name) VALUES ('Light Grey Terracotta');
INSERT INTO blocks(name) VALUES ('Light Grey Wool');
INSERT INTO blocks(name) VALUES ('Lilac');
INSERT INTO blocks(name) VALUES ('Lime Bed');
INSERT INTO blocks(name) VALUES ('Lime Carpet');
INSERT INTO blocks(name) VALUES ('Lime Concrete');
INSERT INTO blocks(name) VALUES ('Lime Concrete Powder');
INSERT INTO blocks(name) VALUES ('Lime Concrete Slab');
INSERT INTO blocks(name) VALUES ('Lime Concrete Stair');
INSERT INTO blocks(name) VALUES ('Lime Glazed Terracotta');
INSERT INTO blocks(name) VALUES ('Lime Shulker Box');
INSERT INTO blocks(name) VALUES ('Lime Stained Glass');
INSERT INTO blocks(name) VALUES ('Lime Stained Glass Pane');
INSERT INTO blocks(name) VALUES ('Lime Terracotta');
INSERT INTO blocks(name) VALUES ('Lime Wool');
INSERT INTO blocks(name) VALUES ('Lit Redstone Ore');
INSERT INTO blocks(name) VALUES ('Magenta Bed');
INSERT INTO blocks(name) VALUES ('Magenta Carpet');
INSERT INTO blocks(name) VALUES ('Magenta Concrete');
INSERT INTO blocks(name) VALUES ('Magenta Concrete Powder');
INSERT INTO blocks(name) VALUES ('Magenta Concrete Slab');
INSERT INTO blocks(name) VALUES ('Magenta Concrete Stair');
INSERT INTO blocks(name) VALUES ('Magenta Glazed Terracotta');
INSERT INTO blocks(name) VALUES ('Magenta Shulker Box');
INSERT INTO blocks(name) VALUES ('Magenta Stained Glass');
INSERT INTO blocks(name) VALUES ('Magenta Stained Glass Pane');
INSERT INTO blocks(name) VALUES ('Magenta Terracotta');
INSERT INTO blocks(name) VALUES ('Magenta Wool');
INSERT INTO blocks(name) VALUES ('Magma Block');
INSERT INTO blocks(name) VALUES ('Mature Beetroot Plant');
INSERT INTO blocks(name) VALUES ('Mature Carrot Plant');
INSERT INTO blocks(name) VALUES ('Mature Cocoa Pod');
INSERT INTO blocks(name) VALUES ('Mature Melon Stem');
INSERT INTO blocks(name) VALUES ('Mature Nether Wart');
INSERT INTO blocks(name) VALUES ('Mature Potato Plant');
INSERT INTO blocks(name) VALUES ('Mature Pumpkin Stem');
INSERT INTO blocks(name) VALUES ('Mature Wheat Plant');
INSERT INTO blocks(name) VALUES ('Medium Cocoa Pod');
INSERT INTO blocks(name) VALUES ('Melon');
INSERT INTO blocks(name) VALUES ('Mob Spawner');
INSERT INTO blocks(name) VALUES ('Mossy Cobblestone');
INSERT INTO blocks(name) VALUES ('Mossy Cobblestone Wall');
INSERT INTO blocks(name) VALUES ('Mossy Stone Brick');
INSERT INTO blocks(name) VALUES ('Mossy Stone Brick Slab');
INSERT INTO blocks(name) VALUES ('Mossy Stone Brick Stair');
INSERT INTO blocks(name) VALUES ('Mossy Stone Brick Wall');
INSERT INTO blocks(name) VALUES ('Mossy Stone Slab');
INSERT INTO blocks(name) VALUES ('Mossy Stone Stair');
INSERT INTO blocks(name) VALUES ('Mycelium');
INSERT INTO blocks(name) VALUES ('Nether Brick Block');
INSERT INTO blocks(name) VALUES ('Nether Brick Fence');
INSERT INTO blocks(name) VALUES ('Nether Brick Fence Gate');
INSERT INTO blocks(name) VALUES ('Nether Brick Slab');
INSERT INTO blocks(name) VALUES ('Nether Brick Stair');
INSERT INTO blocks(name) VALUES ('Nether Brick Wall');
INSERT INTO blocks(name) VALUES ('Nether Lava Source');
INSERT INTO blocks(name) VALUES ('Nether Portal');
INSERT INTO blocks(name) VALUES ('Nether Quartz Ore');
INSERT INTO blocks(name) VALUES ('Netherrack');
INSERT INTO blocks(name) VALUES ('Nether Wart Block');
INSERT INTO blocks(name) VALUES ('Note Block');
INSERT INTO blocks(name) VALUES ('Oak');
INSERT INTO blocks(name) VALUES ('Oak Bark');
INSERT INTO blocks(name) VALUES ('Oak Bark Slab');
INSERT INTO blocks(name) VALUES ('Oak Bark Stair');
INSERT INTO blocks(name) VALUES ('Oak Button');
INSERT INTO blocks(name) VALUES ('Oak Door');
INSERT INTO blocks(name) VALUES ('Oak Fence Gate');
INSERT INTO blocks(name) VALUES ('Oak Ladder');
INSERT INTO blocks(name) VALUES ('Oak Plank');
INSERT INTO blocks(name) VALUES ('Oak Pressure Plate');
INSERT INTO blocks(name) VALUES ('Oak Sapling');
INSERT INTO blocks(name) VALUES ('Oak Sapling Flower Pot');
INSERT INTO blocks(name) VALUES ('Oak Slab');
INSERT INTO blocks(name) VALUES ('Oak Stair');
INSERT INTO blocks(name) VALUES ('Oak Wall Sign');
INSERT INTO blocks(name) VALUES ('Observer');
INSERT INTO blocks(name) VALUES ('Obsidian');
INSERT INTO blocks(name) VALUES ('Obsidian Glass Pane');
INSERT INTO blocks(name) VALUES ('Obsidian Glass Slab');
INSERT INTO blocks(name) VALUES ('Obsidian Glass Stair');
INSERT INTO blocks(name) VALUES ('Obsidian Slab');
INSERT INTO blocks(name) VALUES ('Obsidian Stair');
INSERT INTO blocks(name) VALUES ('Orange Bed');
INSERT INTO blocks(name) VALUES ('Orange Carpet');
INSERT INTO blocks(name) VALUES ('Orange Concrete');
INSERT INTO blocks(name) VALUES ('Orange Concrete Powder');
INSERT INTO blocks(name) VALUES ('Orange Concrete Slab');
INSERT INTO blocks(name) VALUES ('Orange Concrete Stair');
INSERT INTO blocks(name) VALUES ('Orange Glazed Terracotta');
INSERT INTO blocks(name) VALUES ('Orange Shulker Box');
INSERT INTO blocks(name) VALUES ('Orange Stained Glass');
INSERT INTO blocks(name) VALUES ('Orange Stained Glass Pane');
INSERT INTO blocks(name) VALUES ('Orange Terracotta');
INSERT INTO blocks(name) VALUES ('Orange Tulip Flower Pot');
INSERT INTO blocks(name) VALUES ('Orange Tulip');
INSERT INTO blocks(name) VALUES ('Orange Wool');
INSERT INTO blocks(name) VALUES ('Oxeye Daisy Flower Pot');
INSERT INTO blocks(name) VALUES ('Oxeye Daisy');
INSERT INTO blocks(name) VALUES ('Packed Ice');
INSERT INTO blocks(name) VALUES ('Peony');
INSERT INTO blocks(name) VALUES ('Pillar Quartz Block');
INSERT INTO blocks(name) VALUES ('Pink Bed');
INSERT INTO blocks(name) VALUES ('Pink Carpet');
INSERT INTO blocks(name) VALUES ('Pink Concrete');
INSERT INTO blocks(name) VALUES ('Pink Concrete Powder');
INSERT INTO blocks(name) VALUES ('Pink Concrete Slab');
INSERT INTO blocks(name) VALUES ('Pink Concrete Stair');
INSERT INTO blocks(name) VALUES ('Pink Glazed Terracotta');
INSERT INTO blocks(name) VALUES ('Pink Shulker Box');
INSERT INTO blocks(name) VALUES ('Pink Stained Glass');
INSERT INTO blocks(name) VALUES ('Pink Stained Glass Pane');
INSERT INTO blocks(name) VALUES ('Pink Terracotta');
INSERT INTO blocks(name) VALUES ('Pink Tulip Flower Pot');
INSERT INTO blocks(name) VALUES ('Pink Tulip');
INSERT INTO blocks(name) VALUES ('Pink Wool');
INSERT INTO blocks(name) VALUES ('Piston');
INSERT INTO blocks(name) VALUES ('Podzol');
INSERT INTO blocks(name) VALUES ('Polished Andesite');
INSERT INTO blocks(name) VALUES ('Polished Andesite Slab');
INSERT INTO blocks(name) VALUES ('Polished Andesite Stair');
INSERT INTO blocks(name) VALUES ('Polished Diorite');
INSERT INTO blocks(name) VALUES ('Polished Diorite Slab');
INSERT INTO blocks(name) VALUES ('Polished Diorite Stair');
INSERT INTO blocks(name) VALUES ('Polished Granite');
INSERT INTO blocks(name) VALUES ('Polished Granite Slab');
INSERT INTO blocks(name) VALUES ('Polished Granite Stair');
INSERT INTO blocks(name) VALUES ('Polished Stone');
INSERT INTO blocks(name) VALUES ('Poppy');
INSERT INTO blocks(name) VALUES ('Poppy Flower Pot');
INSERT INTO blocks(name) VALUES ('Powered Rail');
INSERT INTO blocks(name) VALUES ('Powered Redstone Spot');
INSERT INTO blocks(name) VALUES ('Powered Redstone Trail');
INSERT INTO blocks(name) VALUES ('Prismarine');
INSERT INTO blocks(name) VALUES ('Prismarine Brick');
INSERT INTO blocks(name) VALUES ('Prismarine Brick Slab');
INSERT INTO blocks(name) VALUES ('Prismarine Brick Stair');
INSERT INTO blocks(name) VALUES ('Prismarine Dark');
INSERT INTO blocks(name) VALUES ('Prismarine Slab');
INSERT INTO blocks(name) VALUES ('Prismarine Stair');
INSERT INTO blocks(name) VALUES ('Prismarine Wall');
INSERT INTO blocks(name) VALUES ('Pumpkin');
INSERT INTO blocks(name) VALUES ('Purple Bed');
INSERT INTO blocks(name) VALUES ('Purple Carpet');
INSERT INTO blocks(name) VALUES ('Purple Concrete');
INSERT INTO blocks(name) VALUES ('Purple Concrete Powder');
INSERT INTO blocks(name) VALUES ('Purple Concrete Slab');
INSERT INTO blocks(name) VALUES ('Purple Concrete Stair');
INSERT INTO blocks(name) VALUES ('Purple Glazed Terracotta');
INSERT INTO blocks(name) VALUES ('Purple Shulker Box');
INSERT INTO blocks(name) VALUES ('Purple Stained Glass');
INSERT INTO blocks(name) VALUES ('Purple Stained Glass Pane');
INSERT INTO blocks(name) VALUES ('Purple Terracotta');
INSERT INTO blocks(name) VALUES ('Purple Wool');
INSERT INTO blocks(name) VALUES ('Purpur Block');
INSERT INTO blocks(name) VALUES ('Purpur Pillar');
INSERT INTO blocks(name) VALUES ('Purpur Slab');
INSERT INTO blocks(name) VALUES ('Purpur Stair');
INSERT INTO blocks(name) VALUES ('Quartz Block');
INSERT INTO blocks(name) VALUES ('Quartz Slab');
INSERT INTO blocks(name) VALUES ('Quartz Stair');
INSERT INTO blocks(name) VALUES ('Rail');
INSERT INTO blocks(name) VALUES ('Realm Barrier');
INSERT INTO blocks(name) VALUES ('Red Bed');
INSERT INTO blocks(name) VALUES ('Red Carpet');
INSERT INTO blocks(name) VALUES ('Red Concrete');
INSERT INTO blocks(name) VALUES ('Red Concrete Powder');
INSERT INTO blocks(name) VALUES ('Red Concrete Slab');
INSERT INTO blocks(name) VALUES ('Red Concrete Stair');
INSERT INTO blocks(name) VALUES ('Red Glazed Terracotta');
INSERT INTO blocks(name) VALUES ('Red Mushroom');
INSERT INTO blocks(name) VALUES ('Red Mushroom Flower Pot');
INSERT INTO blocks(name) VALUES ('Red Nether Brick Block');
INSERT INTO blocks(name) VALUES ('Red Nether Brick Fence Gate');
INSERT INTO blocks(name) VALUES ('Red Nether Brick Fence');
INSERT INTO blocks(name) VALUES ('Red Nether Brick Slab');
INSERT INTO blocks(name) VALUES ('Red Nether Brick Stair');
INSERT INTO blocks(name) VALUES ('Red Nether Brick Wall');
INSERT INTO blocks(name) VALUES ('Red Sand');
INSERT INTO blocks(name) VALUES ('Red Sandstone');
INSERT INTO blocks(name) VALUES ('Red Sandstone Slab');
INSERT INTO blocks(name) VALUES ('Red Sandstone Stair');
INSERT INTO blocks(name) VALUES ('Red Sandstone Wall');
INSERT INTO blocks(name) VALUES ('Red Shulker Box');
INSERT INTO blocks(name) VALUES ('Red Stained Glass');
INSERT INTO blocks(name) VALUES ('Red Stained Glass Pane');
INSERT INTO blocks(name) VALUES ('Redstone');
INSERT INTO blocks(name) VALUES ('Redstone Block');
INSERT INTO blocks(name) VALUES ('Redstone Comparator (Off)');
INSERT INTO blocks(name) VALUES ('Redstone Comparator (On)');
INSERT INTO blocks(name) VALUES ('Redstone Lamp');
INSERT INTO blocks(name) VALUES ('Redstone Ore');
INSERT INTO blocks(name) VALUES ('Redstone Repeater');
INSERT INTO blocks(name) VALUES ('Redstone Repeater (Powered)');
INSERT INTO blocks(name) VALUES ('Redstone Torch');
INSERT INTO blocks(name) VALUES ('Redstone Torch (off)');
INSERT INTO blocks(name) VALUES ('Redstone Trail');
INSERT INTO blocks(name) VALUES ('Red Terracotta');
INSERT INTO blocks(name) VALUES ('Red Tulip Flower Pot');
INSERT INTO blocks(name) VALUES ('Red Tulip');
INSERT INTO blocks(name) VALUES ('Red Wool');
INSERT INTO blocks(name) VALUES ('Riverwaterlogged Sponge');
INSERT INTO blocks(name) VALUES ('River Water Source');
INSERT INTO blocks(name) VALUES ('Rose Bush');
INSERT INTO blocks(name) VALUES ('Sand');
INSERT INTO blocks(name) VALUES ('Sandstone');
INSERT INTO blocks(name) VALUES ('Sandstone Carved');
INSERT INTO blocks(name) VALUES ('Sandstone Slab');
INSERT INTO blocks(name) VALUES ('Sandstone Stair');
INSERT INTO blocks(name) VALUES ('Sandstone Wall');
INSERT INTO blocks(name) VALUES ('Sea Lantern');
INSERT INTO blocks(name) VALUES ('Side Hopper');
INSERT INTO blocks(name) VALUES ('Skeleton Skull');
INSERT INTO blocks(name) VALUES ('Slime Block');
INSERT INTO blocks(name) VALUES ('Smooth Quartz');
INSERT INTO blocks(name) VALUES ('Smooth Quartz Slab');
INSERT INTO blocks(name) VALUES ('Smooth Quartz Stair');
INSERT INTO blocks(name) VALUES ('Smooth Red Sandstone');
INSERT INTO blocks(name) VALUES ('Smooth Red Sandstone Slab');
INSERT INTO blocks(name) VALUES ('Smooth Red Sandstone Stair');
INSERT INTO blocks(name) VALUES ('Smooth Sandstone');
INSERT INTO blocks(name) VALUES ('Smooth Sandstone Slab');
INSERT INTO blocks(name) VALUES ('Smooth Sandstone Stair');
INSERT INTO blocks(name) VALUES ('Snow Block');
INSERT INTO blocks(name) VALUES ('Snow Layer');
INSERT INTO blocks(name) VALUES ('Soul Sand');
INSERT INTO blocks(name) VALUES ('Sponge');
INSERT INTO blocks(name) VALUES ('Spruce Bark');
INSERT INTO blocks(name) VALUES ('Spruce Bark Slab');
INSERT INTO blocks(name) VALUES ('Spruce Bark Stair');
INSERT INTO blocks(name) VALUES ('Spruce Button');
INSERT INTO blocks(name) VALUES ('Spruce Fence');
INSERT INTO blocks(name) VALUES ('Spruce Fence Gate');
INSERT INTO blocks(name) VALUES ('Spruce Leaves');
INSERT INTO blocks(name) VALUES ('Spruce Log');
INSERT INTO blocks(name) VALUES ('Spruce');
INSERT INTO blocks(name) VALUES ('Spruce Pressure Plate');
INSERT INTO blocks(name) VALUES ('Spruce Sapling Flower Pot');
INSERT INTO blocks(name) VALUES ('Spruce Sapling');
INSERT INTO blocks(name) VALUES ('Spruce Slab');
INSERT INTO blocks(name) VALUES ('Spruce Stair');
INSERT INTO blocks(name) VALUES ('Spruce Trapdoor');
INSERT INTO blocks(name) VALUES ('Sticky Piston');
INSERT INTO blocks(name) VALUES ('Stone');
INSERT INTO blocks(name) VALUES ('Stone Brick');
INSERT INTO blocks(name) VALUES ('Stone Brick Carved');
INSERT INTO blocks(name) VALUES ('Stone Brick Cracked');
INSERT INTO blocks(name) VALUES ('Stone Brick Slab');
INSERT INTO blocks(name) VALUES ('Stone Brick Stair');
INSERT INTO blocks(name) VALUES ('Stone Brick Wall');
INSERT INTO blocks(name) VALUES ('Stone Button');
INSERT INTO blocks(name) VALUES ('Stone Pressure Plate');
INSERT INTO blocks(name) VALUES ('Stone Slab');
INSERT INTO blocks(name) VALUES ('Stone Stair');
INSERT INTO blocks(name) VALUES ('Sugar Canes');
INSERT INTO blocks(name) VALUES ('Sunflower');
INSERT INTO blocks(name) VALUES ('Tall Grass');
INSERT INTO blocks(name) VALUES ('Terracotta');
INSERT INTO blocks(name) VALUES ('TNT');
INSERT INTO blocks(name) VALUES ('Torch');
INSERT INTO blocks(name) VALUES ('Trapdoor');
INSERT INTO blocks(name) VALUES ('Trapped Chest');
INSERT INTO blocks(name) VALUES ('Vines');
INSERT INTO blocks(name) VALUES ('Void');
INSERT INTO blocks(name) VALUES ('Waterlily');
INSERT INTO blocks(name) VALUES ('Waterlogged Sponge');
INSERT INTO blocks(name) VALUES ('Water Source');
INSERT INTO blocks(name) VALUES ('White Bed');
INSERT INTO blocks(name) VALUES ('White Carpet');
INSERT INTO blocks(name) VALUES ('White Concrete');
INSERT INTO blocks(name) VALUES ('White Concrete Powder');
INSERT INTO blocks(name) VALUES ('White Concrete Slab');
INSERT INTO blocks(name) VALUES ('White Concrete Stair');
INSERT INTO blocks(name) VALUES ('White Glass Pane');
INSERT INTO blocks(name) VALUES ('White Glazed Terracotta');
INSERT INTO blocks(name) VALUES ('White Shulker Box');
INSERT INTO blocks(name) VALUES ('White Stained Glass');
INSERT INTO blocks(name) VALUES ('White Stained Glass Pane');
INSERT INTO blocks(name) VALUES ('White Terracotta');
INSERT INTO blocks(name) VALUES ('White Tulip Flower Pot');
INSERT INTO blocks(name) VALUES ('White Tulip');
INSERT INTO blocks(name) VALUES ('Wither Skeleton Skull');
INSERT INTO blocks(name) VALUES ('Wool');
INSERT INTO blocks(name) VALUES ('Yellow Bed');
INSERT INTO blocks(name) VALUES ('Yellow Carpet');
INSERT INTO blocks(name) VALUES ('Yellow Concrete');
INSERT INTO blocks(name) VALUES ('Yellow Concrete Powder');
INSERT INTO blocks(name) VALUES ('Yellow Concrete Slab');
INSERT INTO blocks(name) VALUES ('Yellow Concrete Stair');
INSERT INTO blocks(name) VALUES ('Yellow Glazed Terracotta');
INSERT INTO blocks(name) VALUES ('Yellow Shulker Box');
INSERT INTO blocks(name) VALUES ('Yellow Stained Glass');
INSERT INTO blocks(name) VALUES ('Yellow Stained Glass Pane');
INSERT INTO blocks(name) VALUES ('Yellow Terracotta');
INSERT INTO blocks(name) VALUES ('Yellow Wool');
INSERT INTO blocks(name) VALUES ('Zombie Head');
INSERT INTO blocks(name) VALUES ('Air');
INSERT INTO blocks(name) VALUES ('Oak Wood Plank');
INSERT INTO blocks(name) VALUES ('Spruce Wood Plank');
INSERT INTO blocks(name) VALUES ('Birch Wood Plank');
INSERT INTO blocks(name) VALUES ('Jungle Wood Plank');
INSERT INTO blocks(name) VALUES ('Acacia Wood Plank');
INSERT INTO blocks(name) VALUES ('Dark Oak Wood Plank');
INSERT INTO blocks(name) VALUES ('Still Water');
INSERT INTO blocks(name) VALUES ('Still Lava');
INSERT INTO blocks(name) VALUES ('Oak Wood');
INSERT INTO blocks(name) VALUES ('Spruce Wood');
INSERT INTO blocks(name) VALUES ('Birch Wood');
INSERT INTO blocks(name) VALUES ('Jungle Wood');
INSERT INTO blocks(name) VALUES ('Oak Leaves');
INSERT INTO blocks(name) VALUES ('Wet Sponge');
INSERT INTO blocks(name) VALUES ('Chiseled Sandstone');
INSERT INTO blocks(name) VALUES ('Bed');
INSERT INTO blocks(name) VALUES ('Dead Shrub');
INSERT INTO blocks(name) VALUES ('Piston Head');
INSERT INTO blocks(name) VALUES ('White Wool');
INSERT INTO blocks(name) VALUES ('Gray Wool');
INSERT INTO blocks(name) VALUES ('Light Gray Wool');
INSERT INTO blocks(name) VALUES ('Double Wooden Slab');
INSERT INTO blocks(name) VALUES ('Wooden Slab');
INSERT INTO blocks(name) VALUES ('Bricks');
INSERT INTO blocks(name) VALUES ('Moss Stone');
INSERT INTO blocks(name) VALUES ('Monster Spawner');
INSERT INTO blocks(name) VALUES ('Oak Wood Stairs');
INSERT INTO blocks(name) VALUES ('Redstone Wire');
INSERT INTO blocks(name) VALUES ('Wheat Crops');
INSERT INTO blocks(name) VALUES ('Standing Sign Block');
INSERT INTO blocks(name) VALUES ('Oak Door Block');
INSERT INTO blocks(name) VALUES ('Cobblestone Stairs');
INSERT INTO blocks(name) VALUES ('Wall-mounted Sign Block');
INSERT INTO blocks(name) VALUES ('Iron Door Block');
INSERT INTO blocks(name) VALUES ('Wooden Pressure Plate');
INSERT INTO blocks(name) VALUES ('Glowing Redstone Ore');
INSERT INTO blocks(name) VALUES ('Redstone Torch (on)');
INSERT INTO blocks(name) VALUES ('Snow');
INSERT INTO blocks(name) VALUES ('Oak Fence');
INSERT INTO blocks(name) VALUES ('Jack o''Lantern');
INSERT INTO blocks(name) VALUES ('Cake Block');
INSERT INTO blocks(name) VALUES ('Redstone Repeater Block (off)');
INSERT INTO blocks(name) VALUES ('Redstone Repeater Block (on)');
INSERT INTO blocks(name) VALUES ('Gray Stained Glass');
INSERT INTO blocks(name) VALUES ('Light Gray Stained Glass');
INSERT INTO blocks(name) VALUES ('Wooden Trapdoor');
INSERT INTO blocks(name) VALUES ('Stone Monster Egg');
INSERT INTO blocks(name) VALUES ('Cobblestone Monster Egg');
INSERT INTO blocks(name) VALUES ('Stone Brick Monster Egg');
INSERT INTO blocks(name) VALUES ('Mossy Stone Brick Monster Egg');
INSERT INTO blocks(name) VALUES ('Cracked Stone Brick Monster Egg');
INSERT INTO blocks(name) VALUES ('Chiseled Stone Brick Monster Egg');
INSERT INTO blocks(name) VALUES ('Stone Bricks');
INSERT INTO blocks(name) VALUES ('Mossy Stone Bricks');
INSERT INTO blocks(name) VALUES ('Cracked Stone Bricks');
INSERT INTO blocks(name) VALUES ('Chiseled Stone Bricks');
INSERT INTO blocks(name) VALUES ('Brown Mushroom Block');
INSERT INTO blocks(name) VALUES ('Red Mushroom Block');
INSERT INTO blocks(name) VALUES ('Iron Bars');
INSERT INTO blocks(name) VALUES ('Melon Block');
INSERT INTO blocks(name) VALUES ('Pumpkin Stem');
INSERT INTO blocks(name) VALUES ('Melon Stem');
INSERT INTO blocks(name) VALUES ('Brick Stairs');
INSERT INTO blocks(name) VALUES ('Stone Brick Stairs');
INSERT INTO blocks(name) VALUES ('Lily Pad');
INSERT INTO blocks(name) VALUES ('Nether Brick');
INSERT INTO blocks(name) VALUES ('Nether Brick Stairs');
INSERT INTO blocks(name) VALUES ('Nether Wart');
INSERT INTO blocks(name) VALUES ('Enchantment Table');
INSERT INTO blocks(name) VALUES ('Redstone Lamp (inactive)');
INSERT INTO blocks(name) VALUES ('Redstone Lamp (active)');
INSERT INTO blocks(name) VALUES ('Double Oak Wood Slab');
INSERT INTO blocks(name) VALUES ('Double Spruce Wood Slab');
INSERT INTO blocks(name) VALUES ('Double Birch Wood Slab');
INSERT INTO blocks(name) VALUES ('Double Jungle Wood Slab');
INSERT INTO blocks(name) VALUES ('Double Acacia Wood Slab');
INSERT INTO blocks(name) VALUES ('Double Dark Oak Wood Slab');
INSERT INTO blocks(name) VALUES ('Oak Wood Slab');
INSERT INTO blocks(name) VALUES ('Spruce Wood Slab');
INSERT INTO blocks(name) VALUES ('Birch Wood Slab');
INSERT INTO blocks(name) VALUES ('Jungle Wood Slab');
INSERT INTO blocks(name) VALUES ('Acacia Wood Slab');
INSERT INTO blocks(name) VALUES ('Dark Oak Wood Slab');
INSERT INTO blocks(name) VALUES ('Cocoa');
INSERT INTO blocks(name) VALUES ('Sandstone Stairs');
INSERT INTO blocks(name) VALUES ('Tripwire Hook');
INSERT INTO blocks(name) VALUES ('Tripwire');
INSERT INTO blocks(name) VALUES ('Spruce Wood Stairs');
INSERT INTO blocks(name) VALUES ('Birch Wood Stairs');
INSERT INTO blocks(name) VALUES ('Jungle Wood Stairs');
INSERT INTO blocks(name) VALUES ('Beacon');
INSERT INTO blocks(name) VALUES ('Carrots');
INSERT INTO blocks(name) VALUES ('Potatoes');
INSERT INTO blocks(name) VALUES ('Wooden Button');
INSERT INTO blocks(name) VALUES ('Mob Head');
INSERT INTO blocks(name) VALUES ('Weighted Pressure Plate (light)');
INSERT INTO blocks(name) VALUES ('Weighted Pressure Plate (heavy)');
INSERT INTO blocks(name) VALUES ('Redstone Comparator (inactive)');
INSERT INTO blocks(name) VALUES ('Redstone Comparator (active)');
INSERT INTO blocks(name) VALUES ('Quartz Stairs');
INSERT INTO blocks(name) VALUES ('White Hardened Clay');
INSERT INTO blocks(name) VALUES ('Orange Hardened Clay');
INSERT INTO blocks(name) VALUES ('Magenta Hardened Clay');
INSERT INTO blocks(name) VALUES ('Light Blue Hardened Clay');
INSERT INTO blocks(name) VALUES ('Yellow Hardened Clay');
INSERT INTO blocks(name) VALUES ('Lime Hardened Clay');
INSERT INTO blocks(name) VALUES ('Pink Hardened Clay');
INSERT INTO blocks(name) VALUES ('Gray Hardened Clay');
INSERT INTO blocks(name) VALUES ('Light Gray Hardened Clay');
INSERT INTO blocks(name) VALUES ('Cyan Hardened Clay');
INSERT INTO blocks(name) VALUES ('Purple Hardened Clay');
INSERT INTO blocks(name) VALUES ('Blue Hardened Clay');
INSERT INTO blocks(name) VALUES ('Brown Hardened Clay');
INSERT INTO blocks(name) VALUES ('Green Hardened Clay');
INSERT INTO blocks(name) VALUES ('Red Hardened Clay');
INSERT INTO blocks(name) VALUES ('Black Hardened Clay');
INSERT INTO blocks(name) VALUES ('Gray Stained Glass Pane');
INSERT INTO blocks(name) VALUES ('Light Gray Stained Glass Pane');
INSERT INTO blocks(name) VALUES ('Acacia Wood');
INSERT INTO blocks(name) VALUES ('Dark Oak Wood');
INSERT INTO blocks(name) VALUES ('Acacia Wood Stairs');
INSERT INTO blocks(name) VALUES ('Dark Oak Wood Stairs');
INSERT INTO blocks(name) VALUES ('Prismarine Bricks');
INSERT INTO blocks(name) VALUES ('Dark Prismarine');
INSERT INTO blocks(name) VALUES ('Gray Carpet');
INSERT INTO blocks(name) VALUES ('Light Gray Carpet');
INSERT INTO blocks(name) VALUES ('Hardened Clay');
INSERT INTO blocks(name) VALUES ('Block of Coal');
INSERT INTO blocks(name) VALUES ('Free-standing Banner');
INSERT INTO blocks(name) VALUES ('Wall-mounted Banner');
INSERT INTO blocks(name) VALUES ('Red Sandstone Stairs');
INSERT INTO blocks(name) VALUES ('Spruce Door Block');
INSERT INTO blocks(name) VALUES ('Birch Door Block');
INSERT INTO blocks(name) VALUES ('Jungle Door Block');
INSERT INTO blocks(name) VALUES ('Acacia Door Block');
INSERT INTO blocks(name) VALUES ('Dark Oak Door Block');
INSERT INTO blocks(name) VALUES ('Chorus Plant');
INSERT INTO blocks(name) VALUES ('Purpur Stairs');
INSERT INTO blocks(name) VALUES ('Purpur Double Slab');
INSERT INTO blocks(name) VALUES ('End Stone Bricks');
INSERT INTO blocks(name) VALUES ('Beetroot Block');
INSERT INTO blocks(name) VALUES ('End Gateway');
INSERT INTO blocks(name) VALUES ('Repeating Command Block');
INSERT INTO blocks(name) VALUES ('Chain Command Block');
INSERT INTO blocks(name) VALUES ('Red Nether Brick');
INSERT INTO blocks(name) VALUES ('Structure Void');
INSERT INTO blocks(name) VALUES ('Gray Shulker Box');
INSERT INTO blocks(name) VALUES ('Light Gray Shulker Box');
INSERT INTO blocks(name) VALUES ('Gray Glazed Terracotta');
INSERT INTO blocks(name) VALUES ('Light Gray Glazed Terracotta');
INSERT INTO blocks(name) VALUES ('Gray Concrete');
INSERT INTO blocks(name) VALUES ('Light Gray Concrete');
INSERT INTO blocks(name) VALUES ('Gray Concrete Powder');
INSERT INTO blocks(name) VALUES ('Light Gray Concrete Powder');
INSERT INTO blocks(name) VALUES ('Structure Block');
-- biomes INSERT
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Ocean', 0.5, 7);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Deep Ocean', 0.5, 7);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Frozen Ocean', 0, 7);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Deep Frozen Ocean', 0.5, 7);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Cold Ocean', 0.5, 7);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Deep Cold Ocean', 0.5, 7);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Lukewarm Ocean', 0.5, 7);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Deep Lukewarm Ocean', 0.5, 7);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Warm Ocean', 0.5, 7);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('River', 0.5, 3);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Frozen River', 0, 1);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Beach', 0.8, 3);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Stone Shore', 0.2, 2);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Snowy Beach', 0.05, 1);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Forest', 0.7, 3);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Wooded Hills', 0.7, 3);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Flower Forest', 0.7, 3);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Birch Forest', 0.6, 3);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Birch Forest Hills', 0.6, 3);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Tall Birch Forest', 0.7, 3);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Tall Birch Hills', 0.7, 3);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Dark Forest', 0.7, 3);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Dark Forest Hills', 0.7, 3);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Jungle', 0.95, 3);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Jungle Hills', 0.95, 3);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Modified Jungle', 0.95, 3);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Jungle Edge', 0.95, 3);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Modified Jungle Edge', 0.95, 3);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Bamboo Jungle', 0.95, 3);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Bamboo Jungle Hills', 0.95, 3);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Taiga', 0.25, 2);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Taiga Hills', 0.25, 2);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Taiga Mountains', 0.25, 2);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Snowy Taiga', -0.5, 1);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Snowy Taiga Hills', -0.5, 1);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Snowy Taiga Mountains', -0.5, 1);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Giant Tree Taiga', 0.3, 2);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Giant Tree Taiga Hills', 0.3, 2);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Giant Spruce Taiga', 0.25, 2);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Giant Spruce Taiga Hills', 0.25, 2);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Mushroom Fields', 0.9, 3);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Mushroom Field Shore', 0.9, 3);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Swamp', 0.8, 3);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Swamp Hills', 0.8, 3);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Savanna', 1.2, 5);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Savanna Plateau', 1, 5);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Shattered Savanna', 1.1, 5);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Shattered Savanna Plateau', 1, 5);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Plains', 0.8, 3);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Sunflower Plains', 0.8, 3);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Desert', 2, 5);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Desert Hills', 2, 5);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Desert Lakes', 2, 5);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Snowy Tundra', 0, 1);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Snowy Mountains', 0, 1);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Ice Spikes', 0, 1);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Mountains', 0.2, 2);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Wooded Mountains', 0.2, 2);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Gravelly Mountains', 0.2, 2);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Gravelly Mountains+', 0.2, 2);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Badlands', 2, 5);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Badlands Plateau', 2, 5);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Modified Badlands Plateau', 2, 5);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Wooded Badlands Plateau', 2, 5);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Modified Wooded Badlands Plateau', 2, 5);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Eroded Badlands', 2, 5);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Nether Wastes', 2, 6);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Crimson Forest', 2, 6);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Warped Forest', 2, 6);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Soul Sand Valley', 2, 6);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Basalt Deltas', 2, 6);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('The End', 0.5, 4);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Small End Islands', 0.5, 4);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('End Midlands', 0.5, 4);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('End Highlands', 0.5, 4);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('End Barrens', 0.5, 4);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('The Void', 0.5, 8);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Mountain Edge', 0.2, 9);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Deep Warm Ocean', 0.5, 9);
INSERT INTO biomes(name,temperature,biome_type_id) VALUES ('Legacy Frozen Ocean', 0, 9);
INSERT INTO biomes(name,temperature,biome_type_id,deleted) VALUES ('Tundra', 0.5, 1,TRUE);
INSERT INTO biomes(name,temperature,biome_type_id,deleted) VALUES ('Rain Forest', 0.97, 3,TRUE);
INSERT INTO biomes(name,temperature,biome_type_id,deleted) VALUES ('Seasonal Forest', 0.97, 3,TRUE);
INSERT INTO biomes(name,temperature,biome_type_id,deleted) VALUES ('Ice Desert', 0, 1,TRUE);
INSERT INTO biomes(name,temperature,biome_type_id,deleted) VALUES ('Shrubland', 0.5, 3,TRUE);
-- items INSERT
INSERT INTO items(name) VALUES ('Acacia Boat');
INSERT INTO items(name) VALUES ('Armor Stand');
INSERT INTO items(name) VALUES ('Bat Spawn Egg');
INSERT INTO items(name) VALUES ('Bee Spawn Egg');
INSERT INTO items(name) VALUES ('Beetroot Seeds');
INSERT INTO items(name) VALUES ('Birch Boat');
INSERT INTO items(name) VALUES ('Blaze Spawn Egg');
INSERT INTO items(name) VALUES ('Bottle o'' Enchanting');
INSERT INTO items(name) VALUES ('Bow');
INSERT INTO items(name) VALUES ('Bucket');
INSERT INTO items(name) VALUES ('Bucket of Cod');
INSERT INTO items(name) VALUES ('Bucket of Pufferfish');
INSERT INTO items(name) VALUES ('Bucket of Salmon');
INSERT INTO items(name) VALUES ('Bucket of Tropical Fish');
INSERT INTO items(name) VALUES ('Carrot');
INSERT INTO items(name) VALUES ('Cat Spawn Egg');
INSERT INTO items(name) VALUES ('Cave Spider Spawn Egg');
INSERT INTO items(name) VALUES ('Chicken Spawn Egg');
INSERT INTO items(name) VALUES ('Cocoa Beans');
INSERT INTO items(name) VALUES ('Cod Spawn Egg');
INSERT INTO items(name) VALUES ('Cow Spawn Egg');
INSERT INTO items(name) VALUES ('Creeper Spawn Egg');
INSERT INTO items(name) VALUES ('Crossbow');
INSERT INTO items(name) VALUES ('Dark Oak Boat');
INSERT INTO items(name) VALUES ('Dolphin Spawn Egg');
INSERT INTO items(name) VALUES ('Donkey Spawn Egg');
INSERT INTO items(name) VALUES ('Drowned Spawn Egg');
INSERT INTO items(name) VALUES ('Egg');
INSERT INTO items(name) VALUES ('Elder Guardian Spawn Egg');
INSERT INTO items(name) VALUES ('Ender Pearl');
INSERT INTO items(name) VALUES ('End Crystal');
INSERT INTO items(name) VALUES ('Enderman Spawn Egg');
INSERT INTO items(name) VALUES ('Endermite Spawn Egg');
INSERT INTO items(name) VALUES ('Evoker Spawn Egg');
INSERT INTO items(name) VALUES ('Eye of Ender');
INSERT INTO items(name) VALUES ('Firework Rocket');
INSERT INTO items(name) VALUES ('Fire Charge');
INSERT INTO items(name) VALUES ('Fishing Rod');
INSERT INTO items(name) VALUES ('Flint and Steel');
INSERT INTO items(name) VALUES ('Fox Spawn Egg');
INSERT INTO items(name) VALUES ('Ghast Spawn Egg');
INSERT INTO items(name) VALUES ('Guardian Spawn Egg');
INSERT INTO items(name) VALUES ('Hoglin Spawn Egg');
INSERT INTO items(name) VALUES ('Horse Spawn Egg');
INSERT INTO items(name) VALUES ('Husk Spawn Egg');
INSERT INTO items(name) VALUES ('Item Frame');
INSERT INTO items(name) VALUES ('Jungle Boat');
INSERT INTO items(name) VALUES ('Lava Bucket');
INSERT INTO items(name) VALUES ('Lead');
INSERT INTO items(name) VALUES ('Lingering Potions');
INSERT INTO items(name) VALUES ('Llama Spawn Egg');
INSERT INTO items(name) VALUES ('Magma Cube Spawn Egg');
INSERT INTO items(name) VALUES ('Melon Seeds');
INSERT INTO items(name) VALUES ('Minecart');
INSERT INTO items(name) VALUES ('Minecart with Chest');
INSERT INTO items(name) VALUES ('Minecart with Command Block');
INSERT INTO items(name) VALUES ('Minecart with Furnace');
INSERT INTO items(name) VALUES ('Minecart with Hopper');
INSERT INTO items(name) VALUES ('Minecart with TNT');
INSERT INTO items(name) VALUES ('Mooshroom Spawn Egg');
INSERT INTO items(name) VALUES ('Mule Spawn Egg');
INSERT INTO items(name) VALUES ('Nether Wart');
INSERT INTO items(name) VALUES ('Oak Boat');
INSERT INTO items(name) VALUES ('Ocelot Spawn Egg');
INSERT INTO items(name) VALUES ('Painting');
INSERT INTO items(name) VALUES ('Panda Spawn Egg');
INSERT INTO items(name) VALUES ('Parrot Spawn Egg');
INSERT INTO items(name) VALUES ('Phantom Spawn Egg');
INSERT INTO items(name) VALUES ('Pig Spawn Egg');
INSERT INTO items(name) VALUES ('Piglin Spawn Egg');
INSERT INTO items(name) VALUES ('Pillager Spawn Egg');
INSERT INTO items(name) VALUES ('Polar Bear Spawn Egg');
INSERT INTO items(name) VALUES ('Potato');
INSERT INTO items(name) VALUES ('Pufferfish Spawn Egg');
INSERT INTO items(name) VALUES ('Pumpkin Seeds');
INSERT INTO items(name) VALUES ('Rabbit Spawn Egg');
INSERT INTO items(name) VALUES ('Ravager Spawn Egg');
INSERT INTO items(name) VALUES ('Redstone Dust');
INSERT INTO items(name) VALUES ('Salmon Spawn Egg');
INSERT INTO items(name) VALUES ('Sheep Spawn Egg');
INSERT INTO items(name) VALUES ('Shulker Spawn Egg');
INSERT INTO items(name) VALUES ('Silverfish Spawn Egg');
INSERT INTO items(name) VALUES ('Skeleton Horse Spawn Egg');
INSERT INTO items(name) VALUES ('Skeleton Spawn Egg');
INSERT INTO items(name) VALUES ('Slime Spawn Egg');
INSERT INTO items(name) VALUES ('Snowball');
INSERT INTO items(name) VALUES ('Spider Spawn Egg');
INSERT INTO items(name) VALUES ('Splash Potions');
INSERT INTO items(name) VALUES ('Spruce Boat');
INSERT INTO items(name) VALUES ('Squid Spawn Egg');
INSERT INTO items(name) VALUES ('Stray Spawn Egg');
INSERT INTO items(name) VALUES ('Strider Spawn Egg');
INSERT INTO items(name) VALUES ('String');
INSERT INTO items(name) VALUES ('Sweet Berries');
INSERT INTO items(name) VALUES ('Trader Llama Spawn Egg');
INSERT INTO items(name) VALUES ('Trident');
INSERT INTO items(name) VALUES ('Tropical Fish Spawn Egg');
INSERT INTO items(name) VALUES ('Turtle Spawn Egg');
INSERT INTO items(name) VALUES ('Vex Spawn Egg');
INSERT INTO items(name) VALUES ('Villager Spawn Egg');
INSERT INTO items(name) VALUES ('Vindicator Spawn Egg');
INSERT INTO items(name) VALUES ('Wandering Trader Spawn Egg');
INSERT INTO items(name) VALUES ('Water Bucket');
INSERT INTO items(name) VALUES ('Wheat Seeds');
INSERT INTO items(name) VALUES ('Witch Spawn Egg');
INSERT INTO items(name) VALUES ('Wither Skeleton Spawn Egg');
INSERT INTO items(name) VALUES ('Wolf Spawn Egg');
INSERT INTO items(name) VALUES ('Zoglin Spawn Egg');
INSERT INTO items(name) VALUES ('Zombie Horse Spawn Egg');
INSERT INTO items(name) VALUES ('Zombie Pigman Spawn Egg');
INSERT INTO items(name) VALUES ('Zombie Spawn Egg');
INSERT INTO items(name) VALUES ('Apple');
INSERT INTO items(name) VALUES ('Arrow');
INSERT INTO items(name) VALUES ('Baked Potato');
INSERT INTO items(name) VALUES ('Beetroot Soup');
INSERT INTO items(name) VALUES ('Beetroot');
INSERT INTO items(name) VALUES ('Black Dye');
INSERT INTO items(name) VALUES ('Blue Dye');
INSERT INTO items(name) VALUES ('Bone');
INSERT INTO items(name) VALUES ('Bone Meal');
INSERT INTO items(name) VALUES ('Book and Quill');
INSERT INTO items(name) VALUES ('Bowl');
INSERT INTO items(name) VALUES ('Bread');
INSERT INTO items(name) VALUES ('Brown Dye');
INSERT INTO items(name) VALUES ('Carrot on a Stick');
INSERT INTO items(name) VALUES ('Chainmail Boots');
INSERT INTO items(name) VALUES ('Chainmail Chestplate');
INSERT INTO items(name) VALUES ('Chainmail Helmet');
INSERT INTO items(name) VALUES ('Chainmail Leggings');
INSERT INTO items(name) VALUES ('Charcoal');
INSERT INTO items(name) VALUES ('Chorus Fruit');
INSERT INTO items(name) VALUES ('Coal');
INSERT INTO items(name) VALUES ('Cooked Chicken');
INSERT INTO items(name) VALUES ('Cooked Cod');
INSERT INTO items(name) VALUES ('Cooked Mutton');
INSERT INTO items(name) VALUES ('Cooked Porkchop');
INSERT INTO items(name) VALUES ('Cooked Rabbit');
INSERT INTO items(name) VALUES ('Cooked Salmon');
INSERT INTO items(name) VALUES ('Cookie');
INSERT INTO items(name) VALUES ('Cyan Dye');
INSERT INTO items(name) VALUES ('Debug Stick');
INSERT INTO items(name) VALUES ('Diamond Axe');
INSERT INTO items(name) VALUES ('Diamond Boots');
INSERT INTO items(name) VALUES ('Diamond Chestplate');
INSERT INTO items(name) VALUES ('Diamond Helmet');
INSERT INTO items(name) VALUES ('Diamond Hoe');
INSERT INTO items(name) VALUES ('Diamond Horse Armor');
INSERT INTO items(name) VALUES ('Diamond Leggings');
INSERT INTO items(name) VALUES ('Diamond Pickaxe');
INSERT INTO items(name) VALUES ('Diamond Shovel');
INSERT INTO items(name) VALUES ('Diamond Sword');
INSERT INTO items(name) VALUES ('Dried Kelp');
INSERT INTO items(name) VALUES ('Elytra');
INSERT INTO items(name) VALUES ('Empty Map');
INSERT INTO items(name) VALUES ('Enchanted Book');
INSERT INTO items(name) VALUES ('Enchanted Golden Apple');
INSERT INTO items(name) VALUES ('Map or Explorer Map');
INSERT INTO items(name) VALUES ('Glass Bottle');
INSERT INTO items(name) VALUES ('Golden Apple');
INSERT INTO items(name) VALUES ('Golden Axe');
INSERT INTO items(name) VALUES ('Golden Boots');
INSERT INTO items(name) VALUES ('Golden Carrot');
INSERT INTO items(name) VALUES ('Golden Chestplate');
INSERT INTO items(name) VALUES ('Golden Helmet');
INSERT INTO items(name) VALUES ('Golden Hoe');
INSERT INTO items(name) VALUES ('Golden Horse Armor');
INSERT INTO items(name) VALUES ('Golden Leggings');
INSERT INTO items(name) VALUES ('Golden Pickaxe');
INSERT INTO items(name) VALUES ('Golden Shovel');
INSERT INTO items(name) VALUES ('Golden Sword');
INSERT INTO items(name) VALUES ('Gray Dye');
INSERT INTO items(name) VALUES ('Green Dye');
INSERT INTO items(name) VALUES ('Ink Sac');
INSERT INTO items(name) VALUES ('Iron Ingot');
INSERT INTO items(name) VALUES ('Iron Axe');
INSERT INTO items(name) VALUES ('Iron Boots');
INSERT INTO items(name) VALUES ('Iron Chestplate');
INSERT INTO items(name) VALUES ('Iron Helmet');
INSERT INTO items(name) VALUES ('Iron Hoe');
INSERT INTO items(name) VALUES ('Iron Horse Armor');
INSERT INTO items(name) VALUES ('Iron Leggings');
INSERT INTO items(name) VALUES ('Iron Nugget');
INSERT INTO items(name) VALUES ('Iron Pickaxe');
INSERT INTO items(name) VALUES ('Iron Shovel');
INSERT INTO items(name) VALUES ('Iron Sword');
INSERT INTO items(name) VALUES ('Knowledge Book');
INSERT INTO items(name) VALUES ('Lapis Lazuli');
INSERT INTO items(name) VALUES ('Leather Boots');
INSERT INTO items(name) VALUES ('Leather Cap');
INSERT INTO items(name) VALUES ('Leather Horse Armor');
INSERT INTO items(name) VALUES ('Leather Pants');
INSERT INTO items(name) VALUES ('Leather Tunic');
INSERT INTO items(name) VALUES ('Light Blue Dye');
INSERT INTO items(name) VALUES ('Light Gray Dye');
INSERT INTO items(name) VALUES ('Lime Dye');
INSERT INTO items(name) VALUES ('Magenta Dye');
INSERT INTO items(name) VALUES ('Melon Slice');
INSERT INTO items(name) VALUES ('Milk Bucket');
INSERT INTO items(name) VALUES ('Mushroom Stew');
INSERT INTO items(name) VALUES ('Music Disc (Ward)');
INSERT INTO items(name) VALUES ('Music Disc (Wait)');
INSERT INTO items(name) VALUES ('Music Disc (Stal)');
INSERT INTO items(name) VALUES ('Music Disc (Mellohi)');
INSERT INTO items(name) VALUES ('Music Disc (Mall)');
INSERT INTO items(name) VALUES ('Music Disc (Far)');
INSERT INTO items(name) VALUES ('Music Disc (Chirp)');
INSERT INTO items(name) VALUES ('Music Disc (Cat)');
INSERT INTO items(name) VALUES ('Music Disc (Blocks)');
INSERT INTO items(name) VALUES ('Music Disc (13)');
INSERT INTO items(name) VALUES ('Music Disc (11)');
INSERT INTO items(name) VALUES ('Music Disc (Strad)');
INSERT INTO items(name) VALUES ('Name Tag');
INSERT INTO items(name) VALUES ('Orange Dye');
INSERT INTO items(name) VALUES ('Pink Dye');
INSERT INTO items(name) VALUES ('Poisonous Potato');
INSERT INTO items(name) VALUES ('Potions');
INSERT INTO items(name) VALUES ('Pufferfish');
INSERT INTO items(name) VALUES ('Pumpkin Pie');
INSERT INTO items(name) VALUES ('Purple Dye');
INSERT INTO items(name) VALUES ('Rabbit Stew');
INSERT INTO items(name) VALUES ('Raw Beef');
INSERT INTO items(name) VALUES ('Raw Chicken');
INSERT INTO items(name) VALUES ('Raw Cod');
INSERT INTO items(name) VALUES ('Raw Mutton');
INSERT INTO items(name) VALUES ('Raw Porkchop');
INSERT INTO items(name) VALUES ('Raw Rabbit');
INSERT INTO items(name) VALUES ('Raw Salmon');
INSERT INTO items(name) VALUES ('Red Dye');
INSERT INTO items(name) VALUES ('Saddle');
INSERT INTO items(name) VALUES ('Shears');
INSERT INTO items(name) VALUES ('Shield');
INSERT INTO items(name) VALUES ('Spectral Arrow');
INSERT INTO items(name) VALUES ('Spider Eye');
INSERT INTO items(name) VALUES ('Steak');
INSERT INTO items(name) VALUES ('Stone Axe');
INSERT INTO items(name) VALUES ('Stone Hoe');
INSERT INTO items(name) VALUES ('Stone Pickaxe');
INSERT INTO items(name) VALUES ('Stone Shovel');
INSERT INTO items(name) VALUES ('Stone Sword');
INSERT INTO items(name) VALUES ('Sugar');
INSERT INTO items(name) VALUES ('Suspicious Stew');
INSERT INTO items(name) VALUES ('Tipped Arrows');
INSERT INTO items(name) VALUES ('Totem of Undying');
INSERT INTO items(name) VALUES ('Tropical Fish');
INSERT INTO items(name) VALUES ('Turtle Shell');
INSERT INTO items(name) VALUES ('Wheat');
INSERT INTO items(name) VALUES ('White Dye');
INSERT INTO items(name) VALUES ('Wooden Axe');
INSERT INTO items(name) VALUES ('Wooden Hoe');
INSERT INTO items(name) VALUES ('Wooden Pickaxe');
INSERT INTO items(name) VALUES ('Wooden Shovel');
INSERT INTO items(name) VALUES ('Wooden Sword');
INSERT INTO items(name) VALUES ('Written Book');
INSERT INTO items(name) VALUES ('Yellow Dye');
INSERT INTO items(name) VALUES ('Banner Pattern (Thing)');
INSERT INTO items(name) VALUES ('Banner Pattern (Skull Charge)');
INSERT INTO items(name) VALUES ('Banner Pattern (Creeper Charge)');
INSERT INTO items(name) VALUES ('Banner Pattern (Globe)');
INSERT INTO items(name) VALUES ('Banner Pattern (Flower Charge)');
INSERT INTO items(name) VALUES ('Blaze Powder');
INSERT INTO items(name) VALUES ('Blaze Rod');
INSERT INTO items(name) VALUES ('Book');
INSERT INTO items(name) VALUES ('Brick');
INSERT INTO items(name) VALUES ('Clay');
INSERT INTO items(name) VALUES ('Clock');
INSERT INTO items(name) VALUES ('Compass');
INSERT INTO items(name) VALUES ('Diamond');
INSERT INTO items(name) VALUES ('Dragon''s Breath');
INSERT INTO items(name) VALUES ('Emerald');
INSERT INTO items(name) VALUES ('Feather');
INSERT INTO items(name) VALUES ('Fermented Spider Eye');
INSERT INTO items(name) VALUES ('Firework Star');
INSERT INTO items(name) VALUES ('Flint');
INSERT INTO items(name) VALUES ('Glistering Melon Slice');
INSERT INTO items(name) VALUES ('Glowstone Dust');
INSERT INTO items(name) VALUES ('Gold Ingot');
INSERT INTO items(name) VALUES ('Gold Nugget');
INSERT INTO items(name) VALUES ('Ghast Tear');
INSERT INTO items(name) VALUES ('Gunpowder');
INSERT INTO items(name) VALUES ('Heart of the Sea');
INSERT INTO items(name) VALUES ('Honey Bottle');
INSERT INTO items(name) VALUES ('Honeycomb');
INSERT INTO items(name) VALUES ('Leather');
INSERT INTO items(name) VALUES ('Magma Cream');
INSERT INTO items(name) VALUES ('Nautilus Shell');
INSERT INTO items(name) VALUES ('Nether Brick');
INSERT INTO items(name) VALUES ('Nether Quartz');
INSERT INTO items(name) VALUES ('Nether Star');
INSERT INTO items(name) VALUES ('Netherite Ingot');
INSERT INTO items(name) VALUES ('Netherite Scrap');
INSERT INTO items(name) VALUES ('Paper');
INSERT INTO items(name) VALUES ('Phantom Membrane');
INSERT INTO items(name) VALUES ('Popped Chorus Fruit');
INSERT INTO items(name) VALUES ('Prismarine Crystals');
INSERT INTO items(name) VALUES ('Prismarine Shard');
INSERT INTO items(name) VALUES ('Rabbit Hide');
INSERT INTO items(name) VALUES ('Rabbit''s Foot');
INSERT INTO items(name) VALUES ('Scute');
INSERT INTO items(name) VALUES ('Shulker Shell');
INSERT INTO items(name) VALUES ('Slimeball');
INSERT INTO items(name) VALUES ('Stick');
INSERT INTO items(name) VALUES ('Awkward Potion');
INSERT INTO items(name) VALUES ('Mundane Potion');
INSERT INTO items(name) VALUES ('Thick Potion');
INSERT INTO items(name) VALUES ('Potion of Healing');
INSERT INTO items(name) VALUES ('Potion of Fire Resistance');
INSERT INTO items(name) VALUES ('Potion of Regeneration');
INSERT INTO items(name) VALUES ('Potion of Strength');
INSERT INTO items(name) VALUES ('Potion of Swftness');
INSERT INTO items(name) VALUES ('Potion of Night Vision');
INSERT INTO items(name) VALUES ('Potion of Invisibility');
INSERT INTO items(name) VALUES ('Potion of Water Breathing');
INSERT INTO items(name) VALUES ('Potion of Leaping');
INSERT INTO items(name) VALUES ('Potion of Slow Falling');
INSERT INTO items(name) VALUES ('Potion of Poison');
INSERT INTO items(name) VALUES ('Potion of Weakness');
INSERT INTO items(name) VALUES ('Potion of Harmiing');
INSERT INTO items(name) VALUES ('Potion of Slowness');
INSERT INTO items(name) VALUES ('Potion of the Turtle Master');



-- mobs INSERT
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Bat',  6, FALSE, 1, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Cat',  4, TRUE, 1, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Chicken',  10, TRUE, 1, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Cod',  3, FALSE, 2, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Cow',  10, TRUE, 1, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Donkey',  15, TRUE, 1, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Fox',  10, TRUE, 1, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Horse',  15, TRUE, 1, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Mooshroom',  10, TRUE, 1, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Mule',  15, FALSE, 1, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Ocelot',  10, TRUE, 1, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Parrot',  6, FALSE, 1, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Pig',  10, TRUE, 1, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Pufferfish',  3, FALSE, 2, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Rabbit',  3, TRUE, 1, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Salmon',  3, FALSE, 2, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Sheep',  8, TRUE, 1, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Skeleton Horse',  15, FALSE, 4, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Snow Golem',  4, FALSE, 6, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Squid',  10, FALSE, 2, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Tropical Fish',  3, FALSE, 2, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Turtle',  30, TRUE, 2, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Villager',  20, FALSE, 1, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Wandering Trader',  20, FALSE, 1, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Bee',  10, TRUE, 3, 2);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Dolphin',  10, FALSE, 2, 2);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Iron Golem',  100, FALSE, 6, 2);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Llama',  15, TRUE, 1, 2);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Panda',  20, TRUE, 1, 2);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Polar Bear',  30, FALSE, 1, 2);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Wolf',  20, TRUE, 1, 2);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Cave Spider',  12, FALSE, 3, 2);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Enderman',  40, FALSE, 6, 2);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Spider',  16, FALSE, 3, 2);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Zombie Pigman',  20, FALSE, 4, 2);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Blaze',  20, FALSE, 6, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Chicken Jockey',  24, FALSE, 4, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Creeper',  20, FALSE, 6, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Drowned',  20, FALSE, 4, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Elder Guardian',  80, FALSE, 2, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Endermite',  8, FALSE, 3, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Evoker',  24, FALSE, 5, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Ghast',  10, FALSE, 6, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Guardian',  30, FALSE, 2, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Husk',  20, FALSE, 4, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Magma Cube',  16, FALSE, 6, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Phantom',  20, FALSE, 4, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Pillager',  24, FALSE, 5, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Ravager',  100, FALSE, 5, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Shulker',  30, FALSE, 6, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Silverfish',  8, FALSE, 3, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Skeleton',  20, FALSE, 4, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Skeleton Horseman',  35, FALSE, 4, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Slime',  16, FALSE, 6, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Spider Jockey',  26, FALSE, 3, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Stray',  20, FALSE, 4, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Vex',  14, FALSE, 6, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Vindicator',  24, FALSE, 5, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Witch',  26, FALSE, 6, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Wither Skeleton',  20, FALSE, 4, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Zombie',  20, FALSE, 4, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Zombie Villager',  20, FALSE, 4, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Ender Dragon',  200, FALSE, 6, 4);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Wither',  300, FALSE, 4, 4);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Giant',  100, FALSE, 4, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Illusioner',  32, FALSE, 5, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Killer Bunny',  20, FALSE, 1, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Zombie Horse',  11, FALSE, 4, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Old Villager',  20, FALSE, 6, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Old Zombie Villager',  20, FALSE, 4, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Elder Guardian Ghost',  80, FALSE, 2, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Beast Boy ',  5, FALSE, 6, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Human  ',  20, FALSE, 6, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Pigman',  20, FALSE, 6, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Rana ',  13, FALSE, 6, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Steve',  5, FALSE, 6, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Black Steve ',  5, FALSE, 6, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Hoglin',  40, TRUE, 4, 3);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Piglin',  16, FALSE, 4, 2);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Strider',  20, TRUE, 4, 1);
INSERT INTO mobs(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('Zoglin',  40, FALSE, 4, 3);
-- biome_blocks INSERT
INSERT INTO biome_blocks(block_id, biome_id) VALUES (592, 3);
INSERT INTO biome_blocks(block_id, biome_id) VALUES (103, 10);
INSERT INTO biome_blocks(block_id, biome_id) VALUES (573, 10);
INSERT INTO biome_blocks(block_id, biome_id) VALUES (573, 12);
INSERT INTO biome_blocks(block_id, biome_id) VALUES (265, 15);
INSERT INTO biome_blocks(block_id, biome_id) VALUES (430, 15);
INSERT INTO biome_blocks(block_id, biome_id) VALUES (785, 22);
INSERT INTO biome_blocks(block_id, biome_id) VALUES (725, 24);
INSERT INTO biome_blocks(block_id, biome_id) VALUES (38, 18);
INSERT INTO biome_blocks(block_id, biome_id) VALUES (265, 24);
INSERT INTO biome_blocks(block_id, biome_id) VALUES (604, 31);
INSERT INTO biome_blocks(block_id, biome_id) VALUES (265, 45);
INSERT INTO biome_blocks(block_id, biome_id) VALUES (8, 45);
INSERT INTO biome_blocks(block_id, biome_id) VALUES (94, 51);
INSERT INTO biome_blocks(block_id, biome_id) VALUES (573, 51);
INSERT INTO biome_blocks(block_id, biome_id) VALUES (574, 51);
INSERT INTO biome_blocks(block_id, biome_id) VALUES (427, 69);
INSERT INTO biome_blocks(block_id, biome_id) VALUES (594, 70);
INSERT INTO biome_blocks(block_id, biome_id) VALUES (234, 72);
INSERT INTO biome_blocks(block_id, biome_id) VALUES (224, 72);
-- biome_mobs INSERT
INSERT INTO biome_mobs(biome_id, mob_id) VALUES (2, 26);
INSERT INTO biome_mobs(biome_id, mob_id) VALUES (2, 10);
INSERT INTO biome_mobs(biome_id, mob_id) VALUES (12, 22);
INSERT INTO biome_mobs(biome_id, mob_id) VALUES (15, 5);
INSERT INTO biome_mobs(biome_id, mob_id) VALUES (15, 17);
INSERT INTO biome_mobs(biome_id, mob_id) VALUES (15, 31);
INSERT INTO biome_mobs(biome_id, mob_id) VALUES (24, 2);
INSERT INTO biome_mobs(biome_id, mob_id) VALUES (24, 12);
INSERT INTO biome_mobs(biome_id, mob_id) VALUES (29, 29);
INSERT INTO biome_mobs(biome_id, mob_id) VALUES (43, 38);
INSERT INTO biome_mobs(biome_id, mob_id) VALUES (43, 54);
INSERT INTO biome_mobs(biome_id, mob_id) VALUES (43, 59);
INSERT INTO biome_mobs(biome_id, mob_id) VALUES (49, 8);
INSERT INTO biome_mobs(biome_id, mob_id) VALUES (49, 23);
INSERT INTO biome_mobs(biome_id, mob_id) VALUES (51, 23);
INSERT INTO biome_mobs(biome_id, mob_id) VALUES (51, 52);
INSERT INTO biome_mobs(biome_id, mob_id) VALUES (51, 61);
INSERT INTO biome_mobs(biome_id, mob_id) VALUES (67, 35);
INSERT INTO biome_mobs(biome_id, mob_id) VALUES (67, 43);
INSERT INTO biome_mobs(biome_id, mob_id) VALUES (72, 33);
-- mob_breeding_items INSERT
INSERT INTO mob_breeding_items(mob_id, breeding_item_id) VALUES (2, 224);
INSERT INTO mob_breeding_items(mob_id, breeding_item_id) VALUES (2, 228);
INSERT INTO mob_breeding_items(mob_id, breeding_item_id) VALUES (3, 5);
INSERT INTO mob_breeding_items(mob_id, breeding_item_id) VALUES (3, 53);
INSERT INTO mob_breeding_items(mob_id, breeding_item_id) VALUES (3, 104);
INSERT INTO mob_breeding_items(mob_id, breeding_item_id) VALUES (5, 248);
INSERT INTO mob_breeding_items(mob_id, breeding_item_id) VALUES (9, 248);
INSERT INTO mob_breeding_items(mob_id, breeding_item_id) VALUES (13, 73);
INSERT INTO mob_breeding_items(mob_id, breeding_item_id) VALUES (13, 117);
INSERT INTO mob_breeding_items(mob_id, breeding_item_id) VALUES (13, 163);
INSERT INTO mob_breeding_items(mob_id, breeding_item_id) VALUES (15, 15);
INSERT INTO mob_breeding_items(mob_id, breeding_item_id) VALUES (15, 163);
INSERT INTO mob_breeding_items(mob_id, breeding_item_id) VALUES (17, 248);
INSERT INTO mob_breeding_items(mob_id, breeding_item_id) VALUES (31, 134);
INSERT INTO mob_breeding_items(mob_id, breeding_item_id) VALUES (31, 137);
INSERT INTO mob_breeding_items(mob_id, breeding_item_id) VALUES (31, 222);
INSERT INTO mob_breeding_items(mob_id, breeding_item_id) VALUES (31, 223);
INSERT INTO mob_breeding_items(mob_id, breeding_item_id) VALUES (31, 225);
INSERT INTO mob_breeding_items(mob_id, breeding_item_id) VALUES (31, 226);
INSERT INTO mob_breeding_items(mob_id, breeding_item_id) VALUES (31, 230);
-- mob_item_drops INSERT
INSERT INTO mob_item_drops(mob_id,drop_item_id) VALUES (3, 223);
INSERT INTO mob_item_drops(mob_id,drop_item_id) VALUES (3, 273);
INSERT INTO mob_item_drops(mob_id,drop_item_id) VALUES (5, 222);
INSERT INTO mob_item_drops(mob_id,drop_item_id) VALUES (5, 286);
INSERT INTO mob_item_drops(mob_id,drop_item_id) VALUES (8, 286);
INSERT INTO mob_item_drops(mob_id,drop_item_id) VALUES (9, 222);
INSERT INTO mob_item_drops(mob_id,drop_item_id) VALUES (9, 286);
INSERT INTO mob_item_drops(mob_id,drop_item_id) VALUES (13, 226);
INSERT INTO mob_item_drops(mob_id,drop_item_id) VALUES (15, 227);
INSERT INTO mob_item_drops(mob_id,drop_item_id) VALUES (15, 299);
INSERT INTO mob_item_drops(mob_id,drop_item_id) VALUES (17, 225);
INSERT INTO mob_item_drops(mob_id,drop_item_id) VALUES (20, 174);
INSERT INTO mob_item_drops(mob_id,drop_item_id) VALUES (32, 93);
INSERT INTO mob_item_drops(mob_id,drop_item_id) VALUES (33, 30);
INSERT INTO mob_item_drops(mob_id,drop_item_id) VALUES (34, 93);
INSERT INTO mob_item_drops(mob_id,drop_item_id) VALUES (34, 235);
INSERT INTO mob_item_drops(mob_id,drop_item_id) VALUES (36, 263);
INSERT INTO mob_item_drops(mob_id,drop_item_id) VALUES (52, 114);
INSERT INTO mob_item_drops(mob_id,drop_item_id) VALUES (52, 120);
INSERT INTO mob_item_drops(mob_id,drop_item_id) VALUES (64, 291);
-- brewing_recipies INSERT
INSERT INTO brewing_recipies(potion_item_id, ingredient_item_id) VALUES (302, 62);
INSERT INTO brewing_recipies(potion_item_id, ingredient_item_id) VALUES (303, 78);
INSERT INTO brewing_recipies(potion_item_id, ingredient_item_id) VALUES (303, 262);
INSERT INTO brewing_recipies(potion_item_id, ingredient_item_id) VALUES (303, 280);
INSERT INTO brewing_recipies(potion_item_id, ingredient_item_id) VALUES (304, 277);
INSERT INTO brewing_recipies(potion_item_id, ingredient_item_id) VALUES (305, 276);
INSERT INTO brewing_recipies(potion_item_id, ingredient_item_id) VALUES (306, 287);
INSERT INTO brewing_recipies(potion_item_id, ingredient_item_id) VALUES (307, 280);
INSERT INTO brewing_recipies(potion_item_id, ingredient_item_id) VALUES (308, 262);
INSERT INTO brewing_recipies(potion_item_id, ingredient_item_id) VALUES (309, 242);
INSERT INTO brewing_recipies(potion_item_id, ingredient_item_id) VALUES (310, 163);
INSERT INTO brewing_recipies(potion_item_id, ingredient_item_id) VALUES (311, 273);
INSERT INTO brewing_recipies(potion_item_id, ingredient_item_id) VALUES (312, 218);
INSERT INTO brewing_recipies(potion_item_id, ingredient_item_id) VALUES (313, 300);
INSERT INTO brewing_recipies(potion_item_id, ingredient_item_id) VALUES (314, 295);
INSERT INTO brewing_recipies(potion_item_id, ingredient_item_id) VALUES (315, 235);
INSERT INTO brewing_recipies(potion_item_id, ingredient_item_id) VALUES (316, 273);
INSERT INTO brewing_recipies(potion_item_id, ingredient_item_id) VALUES (317, 273);
INSERT INTO brewing_recipies(potion_item_id, ingredient_item_id) VALUES (318, 273);
INSERT INTO brewing_recipies(potion_item_id, ingredient_item_id) VALUES (319, 247);

-- Indices created for tables that are not inserted into often
CREATE INDEX mob_aggressions_index ON mob_aggressions(id);
CREATE INDEX biome_types_index ON biome_types(id);
CREATE INDEX mob_types_index ON mob_types(id);