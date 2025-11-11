using UnityEngine;

public interface iDamageable
{
    // Uma interface define um contrato público que outras classes devem implementar.
    // Aqui declaramos a assinatura TakeDamage(float) — não há implementação.
    // Qualquer classe que implemente iDamageable terá esse método acessível,
    // permitindo que código que usa a interface chame TakeDamage em qualquer
    // objeto que implemente iDamageable sem precisar conhecer a classe concreta.
    void TakeDamage(float amount);
}
