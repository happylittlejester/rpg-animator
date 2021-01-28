using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CastSpell : MonoBehaviour
{
    Animator animator;
    private IEnumerator coroutine;
    [SerializeField] GameObject[] skillParticles;
    [SerializeField] AudioClip[] AudioForSkills;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip[] lowHealth;
    [SerializeField] AudioSource heartBeat;
    [SerializeField] AudioSource backgroundMusic;
    public Slider manaBar;
    public Slider healthBar;

    void Start()
    {
        manaBar.value = manaBar.maxValue;
        healthBar.value = healthBar.maxValue;

        heartBeat.Pause();
        backgroundMusic.Play();

        animator = GetComponent<Animator>();

        for (int i = 0; i < skillParticles.Length; i++)
        {
            skillParticles[i].SetActive(false);
        }
    }

    void Update()
    {
        animator.SetFloat("Vertical", Input.GetAxis("Vertical"));
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));


        if (Input.GetKeyUp(KeyCode.Alpha1)) UseSkill(1);
        if (Input.GetKeyUp(KeyCode.Alpha2)) UseSkill(2);
        if (Input.GetKeyUp(KeyCode.Alpha3)) UseSkill(3);
        if (Input.GetKeyUp(KeyCode.Alpha4)) UseSkill(4);
        if (Input.GetKeyUp(KeyCode.Alpha5)) UseSkill(5);

    }

    public void UseSkill(int skillNumber)
    {
        animator.SetTrigger("Skill" + skillNumber);
        skillParticles[skillNumber - 1].SetActive(true);
        audioSource.clip = AudioForSkills[skillNumber - 1];
        audioSource.Play();

        switch (skillNumber)
        {
            case 1:
                coroutine = WaitToEnableObject(skillParticles[skillNumber - 1], 4f);
                UseMana();
                break;
            case 2:
                coroutine = WaitToEnableObject(skillParticles[skillNumber - 1], 3f);
                UseMana();
                break;
            case 3:
                coroutine = WaitToEnableObject(skillParticles[skillNumber - 1], 3f);
                UseMana();
                break;
            case 4:
                coroutine = WaitToEnableObject(skillParticles[skillNumber - 1], 6f);
                UseMana();
                break;
            case 5:
                coroutine = WaitToEnableObject(skillParticles[skillNumber - 1], 3f);
                UseMana();
                break;
        }
        coroutine = WaitToEnableObject(skillParticles[skillNumber - 1], 2.3f);
        StartCoroutine(coroutine);
    }

    IEnumerator WaitToEnableObject(GameObject obj, float time)
    {
        yield return new WaitForSeconds(time);
        obj.SetActive(false);
    }

    public void UseMana()
    {
        manaBar.value -= 2;

        if (manaBar.value == 0)
        {
            healthBar.value -= 1;
            if (healthBar.value == 2)
            {
                heartBeat.clip = lowHealth[0];
                heartBeat.Play();

                heartBeat.volume = 15;
                backgroundMusic.volume = 0.3f;
            }
        }
    }

}
