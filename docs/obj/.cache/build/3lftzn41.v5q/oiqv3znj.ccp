<!DOCTYPE html>
<!--[if IE]><![endif]-->
<html>

  <head>
    <meta charset="utf-8">
      <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
      <title>Getting Started with Spline Plus | Spline Plus documentation </title>
      <meta name="viewport" content="width=device-width">
      <meta name="title" content="Getting Started with Spline Plus | Spline Plus documentation ">
    
      <link rel="shortcut icon" href="../favicon.ico">
      <link rel="stylesheet" href="../styles/docfx.vendor.css">
      <link rel="stylesheet" href="../styles/docfx.css">
      <link rel="stylesheet" href="../styles/main.css">
      <meta property="docfx:navrel" content="../toc.html">
      <meta property="docfx:tocrel" content="toc.html">
    
    <meta property="docfx:rel" content="../">
    
  </head>
  <body data-spy="scroll" data-target="#affix" data-offset="120">
    <div id="wrapper">
      <header>

        <nav id="autocollapse" class="navbar navbar-inverse ng-scope" role="navigation">
          <div class="container">
            <div class="navbar-header">
              <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#navbar">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
              </button>

              <a class="navbar-brand" href="../index.html">
                <img id="logo" class="svg" src="../Images/Else40.png" alt="">
              </a>
            </div>
            <div class="collapse navbar-collapse" id="navbar">
              <form class="navbar-form navbar-right" role="search" id="search">
                <div class="form-group">
                  <input type="text" class="form-control" id="search-query" placeholder="Search" autocomplete="off">
                </div>
              </form>
            </div>
          </div>
        </nav>

        <div class="subnav navbar navbar-default">
          <div class="container hide-when-search" id="breadcrumb">
            <ul class="breadcrumb">
              <li></li>
            </ul>
          </div>
        </div>
      </header>
      <div class="container body-content">

        <div id="search-results">
          <div class="search-list">Search Results for <span></span></div>
          <div class="sr-items">
            <p><i class="glyphicon glyphicon-refresh index-loading"></i></p>
          </div>
          <ul id="pagination" data-first="First" data-prev="Previous" data-next="Next" data-last="Last"></ul>
        </div>
      </div>
      <div role="main" class="container body-content hide-when-search">

        <div class="sidenav hide-when-search">
          <a class="btn toc-toggle collapse" data-toggle="collapse" href="#sidetoggle" aria-expanded="false" aria-controls="sidetoggle">Show / Hide Table of Contents</a>
          <div class="sidetoggle collapse" id="sidetoggle">
            <div id="sidetoc"></div>
          </div>
        </div>
        <div class="article row grid-right">
          <div class="col-md-10">
            <article class="content wrap" id="_content" data-uid="">
<h1 id="getting-started-with-spline-plus" sourcefile="Introduction/GetStarted.md" sourcestartlinenumber="1">Getting Started with Spline Plus</h1>

<p sourcefile="Introduction/GetStarted.md" sourcestartlinenumber="3">Once you've added the Spline Plus to your Unity project, you can access its various features and settings from the Inspector window.</p>
<div style="text-align: center;">
    <img alt="Spline Plus Inspector" src="../Images/SplinePlus_Inspector.png" style="display: inline-block;" width="600px">
</div>
<h2 id="exploring-spline-plus-features" sourcefile="Introduction/GetStarted.md" sourcestartlinenumber="9">Exploring Spline Plus Features</h2>
<h3 id="accessing-spline-features" sourcefile="Introduction/GetStarted.md" sourcestartlinenumber="10">Accessing Spline Features</h3>
<ul sourcefile="Introduction/GetStarted.md" sourcestartlinenumber="12">
<li sourcefile="Introduction/GetStarted.md" sourcestartlinenumber="12"><strong sourcefile="Introduction/GetStarted.md" sourcestartlinenumber="12">Spline</strong>: The core of Spline Plus grants you access to a plethora of features, including snapping to grid, spline projection into meshes, spline nodes welding, and much more.</li>
</ul>
<div>
    <img src="../Images/SplinePlus_Spline.png" style="display: inline-block;" width="150px">
</div>
<h3 id="manipulating-branches-and-nodes" sourcefile="Introduction/GetStarted.md" sourcestartlinenumber="17">Manipulating Branches and Nodes</h3>
<ul sourcefile="Introduction/GetStarted.md" sourcestartlinenumber="19">
<li sourcefile="Introduction/GetStarted.md" sourcestartlinenumber="19"><strong sourcefile="Introduction/GetStarted.md" sourcestartlinenumber="19">Branches</strong>: Under the &quot;Branch&quot; section, you can perform operations such as adding, removing, diffusing, and reversing the direction of branches.</li>
</ul>
<div>
    <img src="../Images/SplinePlus_Branch.png" style="display: inline-block;" width="150px">
</div>
<ul sourcefile="Introduction/GetStarted.md" sourcestartlinenumber="25">
<li sourcefile="Introduction/GetStarted.md" sourcestartlinenumber="25"><strong sourcefile="Introduction/GetStarted.md" sourcestartlinenumber="25">Nodes</strong>: In the &quot;Nodes&quot; section, you'll find various functionalities like adding, deleting, fusing, changing types, chamfering, breaking, adjusting speed scale, normals, and more.</li>
</ul>
<div>
    <img src="../Images/SplinePlus_Node.png" style="display: inline-block;" width="150px">
</div>
<h3 id="applying-modifiers" sourcefile="Introduction/GetStarted.md" sourcestartlinenumber="30">Applying Modifiers</h3>
<ul sourcefile="Introduction/GetStarted.md" sourcestartlinenumber="31">
<li sourcefile="Introduction/GetStarted.md" sourcestartlinenumber="31"><strong sourcefile="Introduction/GetStarted.md" sourcestartlinenumber="31">Animation Modifiers</strong>: These modifiers offer simple and group followers for spline-based animations. They come equipped with an advanced event system to facilitate interactive spline following, ideal for applications like train systems.</li>
<li sourcefile="Introduction/GetStarted.md" sourcestartlinenumber="32"><strong sourcefile="Introduction/GetStarted.md" sourcestartlinenumber="32">Mesh Modifiers</strong>:  Modifiers in this category offer procedural mesh generation capabilities. Please note that the mesh generation section is a separate package available for purchase on the Unity Asset Store. It provides options such as plane mesh, tube mesh, extrude mesh, and mesh deform to create procedural meshes along the spline.</li>
</ul>
<div class="IMPORTANT" sourcefile="Introduction/GetStarted.md" sourcestartlinenumber="34">
<h5>Important</h5>
<p sourcefile="Introduction/GetStarted.md" sourcestartlinenumber="35">Mesh Modifiers are not directly integrated into Spline Plus. Instead, they are part of a separate package known as Spline Mesh Deform. This package encompasses both Spline Plus functionalities and additional mesh modifiers, providing users with a comprehensive set of tools for spline manipulation and mesh deformation.</p>
</div>
<div>
    <img src="../Images/SplinePlus_Modifiers.png" style="display: inline-block;" width="150px">
</div>
<h2 id="unleash-your-creativity" sourcefile="Introduction/GetStarted.md" sourcestartlinenumber="41">Unleash Your Creativity</h2>
<p sourcefile="Introduction/GetStarted.md" sourcestartlinenumber="43">With Spline Plus, you have a powerful toolset at your disposal for creating intricate spline-based designs, animations, and interactive experiences in Unity. Dive in and explore the possibilities today!</p>
<hr sourcefile="Introduction/GetStarted.md" sourcestartlinenumber="45">
<p sourcefile="Introduction/GetStarted.md" sourcestartlinenumber="47">Ready to take your Unity projects to the next level? Start leveraging Spline Plus to bring your ideas to life!</p>
</article>
          </div>

          <div class="hidden-sm col-md-2" role="complementary">
            <div class="sideaffix">
              <div class="contribution">
                <ul class="nav">
                  <li>
                    <a href="https://github.com/badrdouah/SplinePlus/blob/main/Documentation/Introduction/GetStarted.md/#L1" class="contribution-link">Improve this Doc</a>
                  </li>
                </ul>
              </div>
              <nav class="bs-docs-sidebar hidden-print hidden-xs hidden-sm affix" id="affix">
                <h5>In This Article</h5>
                <div></div>
              </nav>
            </div>
          </div>
        </div>
      </div>

      <footer>
        <div class="grad-bottom"></div>
        <div class="footer">
          <div class="container">
            <span class="pull-right">
              <a href="#top">Back to top</a>
            </span>
      Spline Plus documentation
      
          </div>
        </div>
      </footer>
    </div>

    <script type="text/javascript" src="../styles/docfx.vendor.js"></script>
    <script type="text/javascript" src="../styles/docfx.js"></script>
    <script type="text/javascript" src="../styles/main.js"></script>
  </body>
</html>
