
<body>

<h1>Git & Docker Tutorial</h1>

<h2>Git Functionality: Creating Branches, Merging Changes, and CMD Commands</h2>

<h3>Step 1: Initialize a Git Repository</h3>
<p>Open CMD and navigate to your project folder. Run:</p>
<pre><code>git init</code></pre>

<h3>Step 2: Create a New Branch</h3>
<p>Create and switch to a new branch (example: <strong>feature-branch</strong>):</p>
<pre><code>git checkout -b feature-branch</code></pre>

<h3>Step 3: Make Changes and Commit</h3>
<p>Add files to staging:</p>
<pre><code>git add .</code></pre>

<p>Commit the changes:</p>
<pre><code>git commit -m "Add new feature"</code></pre>

<h3>Step 4: Switch Back to Main Branch</h3>
<pre><code>git checkout main</code></pre>

<h3>Step 5: Merge Changes into Main Branch</h3>
<pre><code>git merge feature-branch</code></pre>

<h3>Step 6: Push Changes to Remote (Optional)</h3>
<pre><code>git push origin main</code></pre>

<h3>Step 7: Delete the Feature Branch (Optional)</h3>
<pre><code>git branch -d feature-branch</code></pre>

<hr>

<h2>Docker Functionality: Build, Run, and Rebuild After Changes</h2>

<h3>Step 1: Build a Docker Image</h3>
<p>Navigate to the directory containing the Dockerfile:</p>
<pre><code>docker build -t dockerproject .</code></pre>

<h3>Step 2: Run the Docker Container</h3>
<pre><code>docker run -d -p 8080:8080 dockerproject</code></pre>

<h3>Step 3: Stop the Container (If Needed)</h3>
<p>List running containers:</p>
<pre><code>docker ps</code></pre>

<p>Stop a container:</p>
<pre><code>docker stop &lt;container-id&gt;</code></pre>

<h3>Step 4: Add Changes and Rebuild</h3>
<p>Remove the old container:</p>
<pre><code>docker rm &lt;container-id&gt;</code></pre>

<p>Rebuild the image:</p>
<pre><code>docker build -t dockerproject .</code></pre>

<p>Run the container again:</p>
<pre><code>docker run -d -p 8080:8080 dockerproject</code></pre>

<h3>Step 5: View Logs (Optional)</h3>
<pre><code>docker logs &lt;container-id&gt;</code></pre>

</body>
</html>
