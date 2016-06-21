using UnityEngine;
using System.Collections;

public class WaveSpawner : MonoBehaviour {

    public enum spawnState
    {
        SPAWNING, WAITING, COUNTING
    };

  [System.Serializable]
   public class wave
    {
        public string name;
        public GameObject enemy;
        public int count;
        public float delay;
    }

    public wave[] waves;

    public GameObject[] spawnPoints;

    private int nextWave = 0;

    public float timeBetweenWaves = 5f;
    public float waveCountDwon = 0f;

    private float searchRate = 1;

    public spawnState state = spawnState.COUNTING;

    void Start()
    {
        searchForSpawn();
        waveCountDwon = timeBetweenWaves;
    }

    void Update()
    {
        if (state == spawnState.WAITING)
        {
           if (!enemyIsAlive())
            {
                WaveCompleted();
            }
           else
            {
                return;
            }
        }
        if (waveCountDwon <= 0)
        {
            if (state != spawnState.SPAWNING )
            {
                StartCoroutine(spawnWave(waves[nextWave]));
                //start spawning 
            }
        }
        else
        {
            waveCountDwon -= Time.deltaTime;
        }        
    }

    void WaveCompleted()
    {
        state = spawnState.COUNTING;
        waveCountDwon = timeBetweenWaves;
        if (nextWave + 1 > waves.Length - 1)
        {
            nextWave = 0;
            Debug.Log("all waves completed");
            // TODO
            ///
            /// add some code which will handle better this exception than just looping you fat fuck
            ///
        }
        else
        {
            nextWave++;
        }
    }

    bool enemyIsAlive()
      {
        searchRate -= Time.deltaTime;

        if (searchRate <=0)
        {
            searchRate = 1f;
            if (GameObject.FindGameObjectsWithTag("enemy").Length == 0)
            {
                return false;
            }
        }
        return true;       
      }

    IEnumerator spawnWave (wave _wave)
    {
        state = spawnState.SPAWNING;

        for (int i = 0;  i< _wave.count; i++)
        {
            spawn(_wave.enemy);
            yield return new WaitForSeconds( _wave.delay);

        }
      
        state = spawnState.WAITING;

        yield break;
    }

    void spawn(GameObject _enemy)
    {
        Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)].transform;

        Instantiate(_enemy, _sp.position, Quaternion.identity);
        Debug.Log(_enemy.name);
    }
    void searchForSpawn()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("spawnPoint");
    }

}
