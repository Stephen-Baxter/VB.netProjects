Module Module1
    Sub Main()
        Dim RPG_Dice As New RPG_Dice

        Do
            RPG_Dice.ResetConsole()
            RPG_Dice.ResetConsole()
            RPG_Dice.OutputRollBuffer()
            RPG_Dice.Instructions()
            RPG_Dice.GetUserInput()
        Loop While RPG_Dice.DiceRoll()

        RPG_Dice = Nothing

    End Sub

End Module
