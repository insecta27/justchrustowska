/*
using System.Collections;
using NUnit.Framework;
using SuperRunner;
using UnityEngine;
using UnityEngine.TestTools;

namespace SuperRunner
{
    public class PlayerDoubleJumpTest
    {
        [UnityTest]

        //public IEnumerator Player_Can_DoubleJump()
        {
            /#1#/Arrange
            UnityEngine.SceneManagement.SceneManager.LoadScene("Level_1");
            yield return null;

            var player = GameObject.FindObjectOfType<PlayerMoveSystem>();
            Assert.IsNotNull(player, "Player not found");

            int jumpLimit = 2;

            // Act
            player.Jump(); // First jump
            yield return new WaitForSeconds(0.1f);

            player.Jump(); // Second jump
            yield return new WaitForSeconds(0.1f);

            player.Jump(); // Third jump – should be ignored
            yield return new WaitForSeconds(0.1f);

            int jumpCount = player.GetJumpCount();

            // Assert
            Assert.AreEqual(jumpLimit, jumpCount, $"Jump count exceeded: Expected {jumpLimit}, Got {jumpCount}");#1#
        }
    }
}
*/
