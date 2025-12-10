using TMPro;
using UnityEngine;

public class ChatUI : MonoBehaviour
{
    public TMP_InputField inputField;
    public TextMeshProUGUI chatWindow;
    public NetworkManagerQuad net;

    public void EnviarMensagem()
    {
        string msg = inputField.text;
        if (string.IsNullOrWhiteSpace(msg)) return;

        string author = "Jogador " + net.paddleIndex;

        net.EnviarChat(author, msg);

        inputField.text = "";
    }

    public void AddMessage(string text)
    {
        chatWindow.text += "\n" + text;
    }
}