using SFB;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FileManager : MonoBehaviour
{
    public InputField inputField;

    public void OpenExplorer()
    {
        // Open file with filter
        var extensions = new[] {
            new ExtensionFilter("Image Files", "png", "jpg", "jpeg" ),
            new ExtensionFilter("Sound Files", "mp3", "wav" ),
            new ExtensionFilter("All Files", "*" ),
        };
        var paths = StandaloneFileBrowser.OpenFilePanel("Open File", "", extensions, true);
        foreach ( var path in paths) { inputField.text = path; }
    }
}
