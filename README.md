# Sistemsko-programiranje---projekt

## Tema nagradnog zadatka

Tema je napraviti aplikaciju koja ima tri gumba i unose teksta u kojima unosimo .exe datoteku koja se pokreće klikom na gumb. Kada se proces pokrene gumb se deaktivira i tek nakon terminiranja procesa gumb se opet aktivira.

## Riješenje zadatka

Zadatak je riješen pomoću C# programskog jezika u windows Forms aplikaciji. Svaki pokrenuti proces je pokrenut u drugoj niti. Razlog tome je da se na svakom procesu može pojedinačno raditi i gasiti bez utjecaja na ostale procese.
<br>
<br>
Primjer pokretanja, čekanja na završetak i terminiranja procesa i niti.
```C#
          private void b_start_first_process_Click(object sender, EventArgs e)
          {
            tFirstProcess = new Thread(() => StartFirstProcess());
            tFirstProcess.Start();
          }
          
          ...
          
          private void StartFirstProcess() {
            Process firstProcess = new Process();
            firstProcess.StartInfo.FileName = this.firstProcessName;
            firstProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            firstProcess.Start();

            this.Invoke(new Action(() => { b_start_first_process.Enabled = false; }));
            this.Invoke(new Action(() => { lbl_first_process.Text = firstProcessName + " has been started!"; }));
            firstProcess.WaitForExit();
            this.Invoke(new Action(() => { b_start_first_process.Enabled = true; }));
            this.Invoke(new Action(() => { lbl_first_process.Text = firstProcessName + " has been terminated!"; }));

            tFirstProcess.Abort();
        }
```
<br>
<br>

Slika Forms aplikacije
![Forms apliacija](https://user-images.githubusercontent.com/93555102/168383643-4a3e7a38-1836-40f8-a040-fbf781968bf7.png)
