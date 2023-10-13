using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;  // Добавлено для доступа к IEnumerator

public class InitTests
{
    [UnityTest]
    public IEnumerator Init_ReturnsCorrectMessage()
    {
        // Arrange
        var init = new Init();

        // Act
        var result = init.Initialize();

        // Assert
        yield return null;
        Assert.AreEqual("Initializing…", result);
    }
}
