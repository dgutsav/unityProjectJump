using UnityEngine;

public class jumpCollision : MonoBehaviour
{
    public Player player;
    void OnCollisionEnter(Collision collision){
        if(collision.collider.tag=="stair"){
            player.jumpEnable = true;
            player.jump2Enable = true;
        }
    }
}
