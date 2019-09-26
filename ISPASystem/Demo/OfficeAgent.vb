Module OfficeAgent
    Private agentController As AgentObjects.Agent
    Private agentCharacter As AgentObjects.IAgentCtlCharacter
    Public Sub initAgent()
        agentController = New AgentObjects.Agent
        With agentController
            .Connected = True
            .Characters.Load("merlin", "merlin.acs")
            agentCharacter = .Characters("merlin")
        End With
    End Sub
    Public Sub loadaction()
        With agentCharacter
            .MoveTo(CShort(Mainfrm.Location.X + 420), CShort(Mainfrm.Location.Y + 130))
            .Show()
            .Play("Announce")
            .Speak("Hello, my name is Merlin. " & _
                "Welcome to the ISPA SYSTEM !")
            .Play("GestureRight")

            ' You can make Merlin's speech sound more natural by inserting speech
            ' output tags like Pau (Pause), Chr (Character of the Voice), 
            ' Emp (Emphasis) or Spd (Speed). Surround each name-value pair with a
            ' backslash character. 


            .Speak("Lets start by making a new invoice,\pau=300\or\pau=500\...")
            .MoveTo(CShort(Mainfrm.Location.X + 520), CShort(Mainfrm.Location.Y + 75))
            .Play("GestureRight")
            .Speak("...try out some of the other features of the program.")

        End With
    End Sub
    Public Sub agentspeak(ByVal str As String)
        With agentCharacter
            .Play("Announce")
            .Speak(str)

        End With
    End Sub

End Module
