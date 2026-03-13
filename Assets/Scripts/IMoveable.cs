using UnityEngine;

public interface IMoveable
{
    Rigidbody2D rb { get; set; }
    bool isFacingRight { get; set; }

    void MoveEnemy(Vector2 velocity);
    void CheckForLeftRightFacing(Vector2 velocity);
}
