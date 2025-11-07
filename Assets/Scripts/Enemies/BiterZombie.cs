using UnityEngine;

namespace ST07.Enemies
{
    // 바이터: 접촉 즉사 처리
    [RequireComponent(typeof(Collider2D))]
    public class BiterZombie : ZombieAI
    {
        protected override void Awake()
        {
            base.Awake(); // 부모 초기화 먼저!
            attackDamage = 9999f; // 사실상 즉사
        }
    }
}


