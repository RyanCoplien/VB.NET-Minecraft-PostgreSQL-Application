
Imports System.Data.Odbc

Public Class CourseProject
    Dim MyCon As New Odbc.OdbcConnection
    Dim selectedRowID As Integer = -1

    Private Sub Insert(table As String, Optional arg1 As Object = "", Optional arg2 As Object = "", Optional arg3 As Object = "", Optional arg4 As Object = "", Optional arg5 As Object = "")
        Try
            MyCon.Open()
            If Not MyCon.State = ConnectionState.Open Then
                MessageBox.Show("Insert: There was an error with opening the DB")
                MyCon.Close()
                Exit Sub
            End If
            Dim cmd As OdbcCommand = MyCon.CreateCommand()
            Select Case table
                Case "mobs"
                    CheckIfEmpty({arg1, arg2, arg3, arg4, arg5})
                    cmd.CommandText = "INSERT INTO " & table & "(name, health, can_be_bred, mob_type_id, mob_aggression_id) VALUES ('" & CStr(arg1) & "', " & CInt(arg2) & ", " & CStr(arg3) & ", " & CInt(arg4) & ", " & CInt(arg5) & ")"
                Case "biomes"
                    CheckIfEmpty({arg1, arg2, arg3})
                    cmd.CommandText = "INSERT INTO " & table & "(name, temperature, biome_type_id) VALUES ('" & CStr(arg1) & "', " & CDbl(arg2) & "," & CInt(arg3) & ")"
                Case "blocks"
                    CheckIfEmpty({arg1})
                    cmd.CommandText = "INSERT INTO " & table & "(name) VALUES ('" & CStr(arg1) & "')"
                Case "items"
                    CheckIfEmpty({arg1})
                    cmd.CommandText = "INSERT INTO " & table & "(name) VALUES ('" & CStr(arg1) & "')"
                Case "biome_types"
                    CheckIfEmpty({arg1})
                    cmd.CommandText = "INSERT INTO " & table & "(name) VALUES ('" & CStr(arg1) & "')"
                Case "brewing_recipies"
                    CheckIfEmpty({arg1, arg2})
                    cmd.CommandText = "INSERT INTO " & table & "(potion_item_id, ingredient_item_id) VALUES (" & CInt(arg1) & "," & CInt(arg2) & ")"
                Case "biome_blocks"
                    CheckIfEmpty({arg1, arg2})
                    cmd.CommandText = "INSERT INTO " & table & "(block_id, biome_id) VALUES (" & CInt(arg1) & "," & CInt(arg2) & ")"
                Case "biome_mobs"
                    CheckIfEmpty({arg1, arg2})
                    cmd.CommandText = "INSERT INTO " & table & "(biome_id, mob_id) VALUES (" & CInt(arg1) & "," & CInt(arg2) & ")"
                Case "mob_item_drops"
                    CheckIfEmpty({arg1, arg2})
                    cmd.CommandText = "INSERT INTO " & table & "(mob_id, drop_item_id) VALUES (" & CInt(arg1) & "," & CInt(arg2) & ")"
                Case "mob_types"
                    CheckIfEmpty({arg1, arg2})
                    cmd.CommandText = "INSERT INTO " & table & "(name) VALUES ('" & CStr(arg1) & "')"
                Case "mob_aggressions"
                    CheckIfEmpty({arg1})
                    cmd.CommandText = "INSERT INTO " & table & "(name) VALUES ('" & CStr(arg1) & "')"
                Case "mob_breeding_items"
                    CheckIfEmpty({arg1, arg2})
                    cmd.CommandText = "INSERT INTO " & table & "(mob_id, breeding_item_id) VALUES (" & CInt(arg1) & "," & CInt(arg2) & ")"
                Case Else
                    MessageBox.Show("Insert: There was not a valid tablename")
                    Exit Sub
            End Select
            lblInsert.Text = "Rows Inserted: " & CStr(cmd.ExecuteNonQuery())

            MyCon.Close()
            RefreshData(table)
        Catch ex As Exception
            MessageBox.Show("InsertMob: " & ex.Message)
            MyCon.Close()
        End Try
    End Sub

    'Refreshes the DataGridView with the newest possible information based on table name provided
    Private Sub RefreshData(table As String)
        Select Case table
            Case "mobs"
                Me.MobsTableAdapter.Fill(Me.Team_09DataSet.mobs)
            Case "biomes"
                Me.BiomesTableAdapter.Fill(Me.Team_09DataSet.biomes)
            Case "blocks"
                Me.BlocksTableAdapter.Fill(Me.Team_09DataSet.blocks)
            Case "items"
                Me.ItemsTableAdapter.Fill(Me.Team_09DataSet.items)
            Case "biome_types"
                Me.Biome_typesTableAdapter.Fill(Me.Team_09DataSet.biome_types)
            Case "brewing_recipies"
                Me.Brewing_recipiesTableAdapter.Fill(Me.Team_09DataSet.brewing_recipies)
            Case "biome_blocks"
                Me.Biome_blocksTableAdapter.Fill(Me.Team_09DataSet.biome_blocks)
            Case "biome_mobs"
                Me.Biome_mobsTableAdapter.Fill(Me.Team_09DataSet.biome_mobs)
            Case "mob_item_drops"
                Me.Mob_item_dropsTableAdapter.Fill(Me.Team_09DataSet.mob_item_drops)
            Case "mob_types"
                Me.Mob_typesTableAdapter.Fill(Me.Team_09DataSet.mob_types)
            Case "mob_aggressions"
                Me.Mob_aggressionsTableAdapter.Fill(Me.Team_09DataSet.mob_aggressions)
            Case "mob_breeding_items"
                Me.Mob_breeding_itemsTableAdapter.Fill(Me.Team_09DataSet.mob_breeding_items)
            Case Else
                MessageBox.Show("RefreshData: There was not a valid tablename")
                Exit Sub
        End Select
    End Sub

    Private Sub UpdateTable(table As String)
        Try
            Dim changes As DataSet
            changes = Team_09DataSet.GetChanges()
            If changes Is Nothing Then
                lblInsert.Text = "Nothing to Update"
                Exit Sub
            End If
            MyCon.Open()
            'Validate()
            Select Case table
                Case "mobs"
                    Me.MobsTableAdapter.Update(Me.Team_09DataSet.mobs)
                Case "biomes"
                    Me.BiomesTableAdapter.Update(Me.Team_09DataSet.biomes)
                Case "blocks"
                    Me.BlocksTableAdapter.Update(Me.Team_09DataSet.blocks)
                Case "items"
                    Me.ItemsTableAdapter.Update(Me.Team_09DataSet.items)
                Case "biome_types"
                    Me.Biome_typesTableAdapter.Update(Me.Team_09DataSet.biome_types)
                Case "brewing_recipies"
                    Me.Brewing_recipiesTableAdapter.Update(Me.Team_09DataSet.brewing_recipies)
                Case "biome_blocks"
                    Me.Biome_blocksTableAdapter.Update(Me.Team_09DataSet.biome_blocks)
                Case "biome_mobs"
                    Me.Biome_mobsTableAdapter.Update(Me.Team_09DataSet.biome_mobs)
                Case "mob_item_drops"
                    Me.Mob_item_dropsTableAdapter.Update(Me.Team_09DataSet.mob_item_drops)
                Case "mob_types"
                    Me.Mob_typesTableAdapter.Update(Me.Team_09DataSet.mob_types)
                Case "mob_aggressions"
                    Me.Mob_aggressionsTableAdapter.Update(Me.Team_09DataSet.mob_aggressions)
                Case "mob_breeding_items"
                    Me.Mob_breeding_itemsTableAdapter.Update(Me.Team_09DataSet.mob_breeding_items)
                Case Else
                    MessageBox.Show("RefreshData: There was not a valid tablename")
                    Exit Sub
            End Select

            MyCon.Close()
            RefreshData(table)
        Catch ex As Exception
            MessageBox.Show("UpdateTable: " & ex.Message)
            MyCon.Close()
        End Try
    End Sub

    Private Sub CheckIfEmpty(args() As Object)
        For Each arg In args
            If arg.Equals("") Then
                MessageBox.Show("One of your textboxes was empty!")
                Exit Sub
            End If
        Next
    End Sub

    Private Sub DeleteRow(table As String)
        Try
            MyCon.Open()
            If Not MyCon.State = ConnectionState.Open Then
                MessageBox.Show("DeleteRow: There was an error with opening the DB")
                MyCon.Close()
                Exit Sub
            End If
            Dim cmd As OdbcCommand = MyCon.CreateCommand()
            cmd.CommandText = "UPDATE " & table & " SET deleted = TRUE WHERE id = " & CStr(selectedRowID) & ";"
            lblInsert.Text = "Rows Updated: " & CStr(cmd.ExecuteNonQuery())

            MyCon.Close()
            RefreshData(table)
        Catch ex As Exception
            MessageBox.Show("DeleteRow: " & ex.Message)
            MyCon.Close()
        End Try
    End Sub

    Private Sub SelectStatement(Query As String)
        Try
            Dim selectDataSet As New DataSet
            MyCon.Open()
            If Not MyCon.State = ConnectionState.Open Then
                MessageBox.Show("Select: There was an error with opening the DB")
                MyCon.Close()
                Exit Sub
            End If
            Dim adpSelect As New OdbcDataAdapter(Query, MyCon)
            adpSelect.Fill(selectDataSet)
            DataGridViewSelect.DataSource = selectDataSet.Tables(0)
            MyCon.Close()
        Catch ex As Exception
            MessageBox.Show("Select: " & ex.Message)
            MyCon.Close()
        End Try
    End Sub

    'You are now entering the land of event handlers.!! BEWARE !!!
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ItemsTableAdapter.Fill(Me.Team_09DataSet.items)
        Me.Biome_mobsTableAdapter.Fill(Me.Team_09DataSet.biome_mobs)
        Me.Mob_item_dropsTableAdapter.Fill(Me.Team_09DataSet.mob_item_drops)
        Me.Brewing_recipiesTableAdapter.Fill(Me.Team_09DataSet.brewing_recipies)
        Me.Mob_breeding_itemsTableAdapter.Fill(Me.Team_09DataSet.mob_breeding_items)
        Me.Mob_typesTableAdapter.Fill(Me.Team_09DataSet.mob_types)
        Me.Mob_aggressionsTableAdapter.Fill(Me.Team_09DataSet.mob_aggressions)
        Me.Biome_blocksTableAdapter.Fill(Me.Team_09DataSet.biome_blocks)
        Me.Biome_typesTableAdapter.Fill(Me.Team_09DataSet.biome_types)
        Me.BlocksTableAdapter.Fill(Me.Team_09DataSet.blocks)
        Me.BiomesTableAdapter.Fill(Me.Team_09DataSet.biomes)
        Me.MobsTableAdapter.Fill(Me.Team_09DataSet.mobs)
        MyCon.ConnectionString = "Driver={PostgreSQL ANSI};database=team_09;server=75.100.19.88;port=5432;uid=coplienr;sslmode=disable;readonly=0;protocol=7.4;User ID=coplienr;password=cgfWPcLEQHB2z75;"
        lblInsert.Text = ""
    End Sub
    Private Sub btnBiomesInsert_Click(sender As Object, e As EventArgs) Handles btnBiomesInsert.Click
        Insert("biomes", txtBoxBiomesName.Text, txtBoxBiomesTemp.Text, txtBoxBiomesTypeID.Text)
    End Sub
    Private Sub btnMobsInsert_Click(sender As Object, e As EventArgs) Handles btnMobsInsert.Click
        Insert("mobs", txtBoxNameMobs.Text, txtBoxHealthMobs.Text, txtBoxBredMobs.Text, txtBoxTypeMobs.Text, txtBoxAggMobs.Text)
    End Sub
    Private Sub btnBlocksInsert_Click(sender As Object, e As EventArgs) Handles btnBlocksInsert.Click
        Insert("blocks", txtBoxBlocksName.Text)
    End Sub
    Private Sub btnItemsInsert_Click(sender As Object, e As EventArgs) Handles btnItemsInsert.Click
        Insert("items", txtBoxItemsName.Text)
    End Sub
    Private Sub btnBiomeTypesInsert_Click(sender As Object, e As EventArgs) Handles btnBiomeTypesInsert.Click
        Insert("biome_types", txtBoxBiomeTypesName.Text)
    End Sub
    Private Sub btnBiomeBlocksInsert_Click(sender As Object, e As EventArgs) Handles btnBiomeBlocksInsert.Click
        Insert("biome_blocks", txtBoxBiomeBlocksBiomeID.Text, txtBoxBiomeBlocksBlockID.Text)
    End Sub
    Private Sub btnMobAggInsert_Click(sender As Object, e As EventArgs) Handles btnMobAggInsert.Click
        Insert("mob_aggressions", txtBoxMobAggName.Text)
    End Sub
    Private Sub btnMobTypesInsert_Click(sender As Object, e As EventArgs) Handles btnMobTypesInsert.Click
        Insert("mob_types", txtBoxMobTypesName.Text)
    End Sub
    Private Sub btnMobBreedInsert_Click(sender As Object, e As EventArgs) Handles btnMobBreedInsert.Click
        Insert("mob_breeding_items", txtBoxMobBreedMobID.Text, txtBoxMobBreedBreedID.Text)
    End Sub
    Private Sub btnBrewRecInsert_Click(sender As Object, e As EventArgs) Handles btnBrewRecInsert.Click
        Insert("brewing_recipies", txtBoxBrewRecPotionID.Text, txtBoxBrewRecIngredID.Text)
    End Sub
    Private Sub btnMobItemDropsInsert_Click(sender As Object, e As EventArgs) Handles btnMobItemDropsInsert.Click
        Insert("mob_item_drops", txtBoxMobitemDropsMobID.Text, txtBoxMobItemDropsDropItemID.Text)
    End Sub
    Private Sub btnBiomeMobsInsert_Click(sender As Object, e As EventArgs) Handles btnBiomeMobsInsert.Click
        Insert("biome_mobs", txtBoxBiomeMobsBiomeID.Text, txtBoxBiomeMobsMobID.Text)
    End Sub
    Private Sub BiomesDataGridView_CellClickr(sender As Object, e As DataGridViewCellEventArgs) Handles BiomesDataGridView.CellClick
        selectedRowID = CInt(BiomesDataGridView.CurrentRow.Cells(0).Value)
    End Sub
    Private Sub btnBiomesDelete_Click(sender As Object, e As EventArgs) Handles btnBiomesDelete.Click
        DeleteRow("biomes")
    End Sub
    Private Sub btnItemsDelete_Click(sender As Object, e As EventArgs) Handles btnItemsDelete.Click
        DeleteRow("items")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnMobsDelete.Click
        DeleteRow("mobs")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnBiomeTypesDelete.Click
        DeleteRow("biome_types")
    End Sub
    Private Sub btnBiomeBlocksDelete_Click(sender As Object, e As EventArgs) Handles btnBiomeBlocksDelete.Click
        DeleteRow("biome_blocks")
    End Sub
    Private Sub btnMobAggDelete_Click(sender As Object, e As EventArgs) Handles btnMobAggDelete.Click
        DeleteRow("mob_aggressions")
    End Sub
    Private Sub btnMobTypesDelete_Click(sender As Object, e As EventArgs) Handles btnMobTypesDelete.Click
        DeleteRow("mob_types")
    End Sub
    Private Sub btnMobBreedItemsDelete_Click(sender As Object, e As EventArgs) Handles btnMobBreedItemsDelete.Click
        DeleteRow("mob_breeding_items")
    End Sub
    Private Sub btnBrewRecDelete_Click(sender As Object, e As EventArgs) Handles btnBrewRecDelete.Click
        DeleteRow("brewing_recipies")
    End Sub
    Private Sub btnMobItemDropsDelete_Click(sender As Object, e As EventArgs) Handles btnMobItemDropsDelete.Click
        DeleteRow("mob_item_drops")
    End Sub
    Private Sub btnBiomeMobsDelete_Click(sender As Object, e As EventArgs) Handles btnBiomeMobsDelete.Click
        DeleteRow("biome_mobs")
    End Sub
    Private Sub BlocksDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BlocksDataGridView.CellClick
        selectedRowID = CInt(BlocksDataGridView.CurrentRow.Cells(0).Value)
    End Sub
    Private Sub ItemsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemsDataGridView.CellClick
        selectedRowID = CInt(ItemsDataGridView.CurrentRow.Cells(0).Value)
    End Sub
    Private Sub MobsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MobsDataGridView.CellClick
        selectedRowID = CInt(MobsDataGridView.CurrentRow.Cells(0).Value)
    End Sub
    Private Sub Biome_typesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Biome_typesDataGridView.CellClick
        selectedRowID = CInt(Biome_typesDataGridView.CurrentRow.Cells(0).Value)
    End Sub
    Private Sub Biome_blocksDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Biome_blocksDataGridView.CellClick
        selectedRowID = CInt(Biome_blocksDataGridView.CurrentRow.Cells(0).Value)
    End Sub
    Private Sub Mob_aggressionsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Mob_aggressionsDataGridView.CellClick
        selectedRowID = CInt(Mob_aggressionsDataGridView.CurrentRow.Cells(0).Value)
    End Sub
    Private Sub Mob_typesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Mob_typesDataGridView.CellClick
        selectedRowID = CInt(Mob_typesDataGridView.CurrentRow.Cells(0).Value)
    End Sub
    Private Sub Mob_breeding_itemsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Mob_breeding_itemsDataGridView.CellClick
        selectedRowID = CInt(Mob_breeding_itemsDataGridView.CurrentRow.Cells(0).Value)
    End Sub
    Private Sub Brewing_recipiesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Brewing_recipiesDataGridView.CellClick
        selectedRowID = CInt(Brewing_recipiesDataGridView.CurrentRow.Cells(0).Value)
    End Sub
    Private Sub Mob_item_dropsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Mob_item_dropsDataGridView.CellClick
        selectedRowID = CInt(Mob_item_dropsDataGridView.CurrentRow.Cells(0).Value)
    End Sub
    Private Sub Biome_mobsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Biome_mobsDataGridView.CellClick
        selectedRowID = CInt(Biome_mobsDataGridView.CurrentRow.Cells(0).Value)
    End Sub
    Private Sub btnMobsUpdate_Click(sender As Object, e As EventArgs) Handles btnMobsUpdate.Click
        UpdateTable("mobs")
    End Sub
    Private Sub btnBiomesUpdate_Click(sender As Object, e As EventArgs) Handles btnBiomesUpdate.Click
        UpdateTable("biomes")
    End Sub
    Private Sub btnBlocksUpdate_Click(sender As Object, e As EventArgs) Handles btnBlocksUpdate.Click
        UpdateTable("blocks")
    End Sub
    Private Sub btnItemsUpdate_Click(sender As Object, e As EventArgs) Handles btnItemsUpdate.Click
        UpdateTable("items")
    End Sub
    Private Sub btnBiomeTypesUpdate_Click(sender As Object, e As EventArgs) Handles btnBiomeTypesUpdate.Click
        UpdateTable("biome_types")
    End Sub
    Private Sub btnBiomeBlocksUpdate_Click(sender As Object, e As EventArgs) Handles btnBiomeBlocksUpdate.Click
        UpdateTable("biome_blocks")
    End Sub
    Private Sub btnMobAggUpdate_Click(sender As Object, e As EventArgs) Handles btnMobAggUpdate.Click
        UpdateTable("mob_aggressions")
    End Sub
    Private Sub btnMobTypesUpdate_Click(sender As Object, e As EventArgs) Handles btnMobTypesUpdate.Click
        UpdateTable("mob_types")
    End Sub
    Private Sub btnMobBreedUpdate_Click(sender As Object, e As EventArgs) Handles btnMobBreedUpdate.Click
        UpdateTable("mob_breeding_items")
    End Sub
    Private Sub btnBrewRecUpdate_Click(sender As Object, e As EventArgs) Handles btnBrewRecUpdate.Click
        UpdateTable("brewing_recipies")
    End Sub
    Private Sub btnMobItemDropsUpdate_Click(sender As Object, e As EventArgs) Handles btnMobItemDropsUpdate.Click
        UpdateTable("mob_item_drops")
    End Sub
    Private Sub btnBiomeMobsUpdate_Click(sender As Object, e As EventArgs) Handles btnBiomeMobsUpdate.Click
        UpdateTable("biome_mobs")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxMainTable.SelectedIndexChanged
        Select Case CStr(comboBoxMainTable.SelectedItem)
            Case "Mobs"
                SelectStatement("SELECT mobs.name, health, can_be_bred, mob_types.name As mob_type, mob_aggressions.name AS mob_aggression from mobs 
                                    INNER Join mob_types ON mob_types.id = mobs.mob_type_id INNER Join mob_aggressions ON mob_aggressions.id = mobs.mob_aggression_id
                                    ORDER BY mobs.id;")
            Case "Biomes"
                SelectStatement("SELECT biomes.name, temperature, biome_types.name AS biome_type from biomes INNER JOIN biome_types ON biome_types.id = biomes.biome_type_id
                                    ORDER BY biomes.id;")
            Case "Blocks"
                SelectStatement("SELECT name from blocks ORDER BY blocks.id;")
            Case "Items"
                SelectStatement("SELECT name from items ORDER BY items.id;")
            Case "Biome Types"
                SelectStatement("SELECT name from biome_types ORDER by biome_types.id;")
            Case "Brewing Recipies"
                SelectStatement("SELECT items.name AS potion_name, items2.name AS ingredient_name from brewing_recipies INNER JOIN items ON items.id = brewing_recipies.potion_item_id
                                    INNER JOIN items As items2 ON items2.id = brewing_recipies.ingredient_item_id ORDER BY brewing_recipies.id;")
            Case "Biome Blocks"
                SelectStatement("SELECT blocks.name AS block_name, biomes.name AS biome_name from biome_blocks INNER JOIN blocks ON blocks.id = biome_blocks.block_id
                                    INNER JOIN biomes ON biomes.id = biome_blocks.biome_id ORDER BY biome_blocks.id;")
            Case "Biome Mobs"
                SelectStatement("SELECT biomes.name AS biome_name, mobs.name AS mob_name from biome_mobs INNER JOIN mobs ON mobs.id = biome_mobs.mob_id 
                                    INNER JOIN biomes ON biomes.id = biome_mobs.biome_id ORDER BY biome_mobs.id;")
            Case "Mob Item Drops"
                SelectStatement("SELECT mobs.name AS mob_name, items.name AS drop_item_name from mob_item_drops INNER JOIN mobs ON mobs.id = mob_item_drops.mob_id
                                    INNER JOIN items ON items.id = mob_item_drops.drop_item_id ORDER BY mob_item_drops.id;")
            Case "Mob Types"
                SelectStatement("SELECT name from mob_types ORDER by mob_types.id;")
            Case "Mob Aggressions"
                SelectStatement("SELECT name from mob_aggressions ORDER by mob_aggressions.id;")
            Case "Mob Breeding Items"
                SelectStatement("SELECT mobs.name AS mob_name, items.name AS breeding_item_name from mob_breeding_items INNER JOIN mobs ON mobs.id = mob_breeding_items.mob_id
                                    INNER JOIN items ON items.id = mob_breeding_items.breeding_item_id ORDER BY mob_breeding_items.id;")
        End Select
    End Sub

    Private Sub btnViewRun_Click(sender As Object, e As EventArgs) Handles btnViewRun.Click
        SelectStatement(txtBoxViewCustom.Text)
    End Sub
End Class