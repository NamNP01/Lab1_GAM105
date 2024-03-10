using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pianocontroller : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource _do, _re,_mi,_pha,_son,_la,_si;
    public Sprite PhimDangAn;
    public Sprite phimBt;
    void Start()
    {
        Debug.Log("bat dau");
        _do=GameObject.FindWithTag("do").GetComponent<AudioSource>();
        _re = GameObject.FindWithTag("re").GetComponent<AudioSource>();
        _mi = GameObject.FindWithTag("mi").GetComponent<AudioSource>();
        _pha = GameObject.FindWithTag("pha").GetComponent<AudioSource>();
        _son = GameObject.FindWithTag("son").GetComponent<AudioSource>();
        _la = GameObject.FindWithTag("la").GetComponent<AudioSource>();
        _si = GameObject.FindWithTag("si").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            GameObject.FindWithTag("do").GetComponent<SpriteRenderer>().sprite = PhimDangAn;
            _do.Play();
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            GameObject.FindWithTag("do").GetComponent<SpriteRenderer>().sprite = phimBt;
        }


        if (Input.GetKeyDown(KeyCode.R))
        {
            GameObject.FindWithTag("re").GetComponent<SpriteRenderer>().sprite = PhimDangAn;
            _re.Play();
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            GameObject.FindWithTag("re").GetComponent<SpriteRenderer>().sprite = phimBt;
        }


        if (Input.GetKeyDown(KeyCode.M))
        {
            GameObject.FindWithTag("mi").GetComponent<SpriteRenderer>().sprite = PhimDangAn;
            _mi.Play();
        }
        if (Input.GetKeyUp(KeyCode.M))
        {
            GameObject.FindWithTag("mi").GetComponent<SpriteRenderer>().sprite = phimBt;
        }


        if (Input.GetKeyDown(KeyCode.P))
        {
            GameObject.FindWithTag("pha").GetComponent<SpriteRenderer>().sprite = PhimDangAn;
            _pha.Play();
        }
        if (Input.GetKeyUp(KeyCode.P))
        {
            GameObject.FindWithTag("pha").GetComponent<SpriteRenderer>().sprite = phimBt;
        }


        if (Input.GetKeyDown(KeyCode.S))
        {
            GameObject.FindWithTag("son").GetComponent<SpriteRenderer>().sprite = PhimDangAn;
            _son.Play();
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            GameObject.FindWithTag("son").GetComponent<SpriteRenderer>().sprite = phimBt;
        }


        if (Input.GetKeyDown(KeyCode.L))
        {
            GameObject.FindWithTag("la").GetComponent<SpriteRenderer>().sprite = PhimDangAn;
            _la.Play();
        }
        if (Input.GetKeyUp(KeyCode.L))
        {
            GameObject.FindWithTag("la").GetComponent<SpriteRenderer>().sprite = phimBt;
        }


        if (Input.GetKeyDown(KeyCode.I))
        {
            GameObject.FindWithTag("si").GetComponent<SpriteRenderer>().sprite = PhimDangAn;
            _si.Play();
        }
        if (Input.GetKeyUp(KeyCode.I))
        {
            GameObject.FindWithTag("si").GetComponent<SpriteRenderer>().sprite = phimBt;
        }
    }
}
