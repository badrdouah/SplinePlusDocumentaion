<!DOCTYPE html>
<!--[if IE]><![endif]-->
<html>

  <head>
    <meta charset="utf-8">
      <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
      <title>Class NodeAPI
 | Spline Plus documentation </title>
      <meta name="viewport" content="width=device-width">
      <meta name="title" content="Class NodeAPI
 | Spline Plus documentation ">
    
      <link rel="shortcut icon" href="../favicon.ico">
      <link rel="stylesheet" href="../styles/docfx.vendor.css">
      <link rel="stylesheet" href="../styles/docfx.css">
      <link rel="stylesheet" href="../styles/main.css">
      <meta property="docfx:navrel" content="">
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
                <img id="logo" class="svg" src="../logo.svg" alt="">
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
            <article class="content wrap" id="_content" data-uid="ElseForty.Splineplus.API.NodeAPI">


  <h1 id="ElseForty_Splineplus_API_NodeAPI" data-uid="ElseForty.Splineplus.API.NodeAPI" class="text-break">Class NodeAPI
</h1>
  <div class="markdown level0 summary"></div>
  <div class="markdown level0 conceptual"></div>
  <div class="inheritance">
    <h5>Inheritance</h5>
    <div class="level0"><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.object">object</a></div>
    <div class="level1"><span class="xref">NodeAPI</span></div>
  </div>
  <h6><strong>Namespace</strong>: <span class="xref">ElseForty</span>.<span class="xref">Splineplus</span>.<a class="xref" href="ElseForty.Splineplus.API.html">API</a></h6>
  <h6><strong>Assembly</strong>: cs.temp.dll.dll</h6>
  <h5 id="ElseForty_Splineplus_API_NodeAPI_syntax">Syntax</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public class NodeAPI</code></pre>
  </div>
  <h3 id="methods">Methods
</h3>


  <a id="ElseForty_Splineplus_API_NodeAPI_Auto_Smooth_Handles_" data-uid="ElseForty.Splineplus.API.NodeAPI.Auto_Smooth_Handles*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_Auto_Smooth_Handles_SplinePlus_System_Int32_System_Int32_" data-uid="ElseForty.Splineplus.API.NodeAPI.Auto_Smooth_Handles(SplinePlus,System.Int32,System.Int32)">Auto_Smooth_Handles(SplinePlus, int, int)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">Automatically smooths the handles of the specified node in the spline.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static void Auto_Smooth_Handles(SplinePlus splinePlus, int branchKey, int nodeIndex)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">SplinePlus</span></td>
        <td><span class="parametername">splinePlus</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The SplinePlus component containing the spline.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.int32">int</a></td>
        <td><span class="parametername">branchKey</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The key of the branch containing the node.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.int32">int</a></td>
        <td><span class="parametername">nodeIndex</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The index of the node within the branch.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_Chamfer_" data-uid="ElseForty.Splineplus.API.NodeAPI.Chamfer*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_Chamfer_SplinePlus_ElseForty_Splineplus_Models_NodeModel_System_Single_" data-uid="ElseForty.Splineplus.API.NodeAPI.Chamfer(SplinePlus,ElseForty.splineplus.models.NodeModel,System.Single)">Chamfer(SplinePlus, NodeModel, float)</h4>
  <div class="markdown level1 summary"></div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static void Chamfer(SplinePlus splinePlus, NodeModel node, float value)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">SplinePlus</span></td>
        <td><span class="parametername">splinePlus</span></td>
        <td></td>
      </tr>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">node</span></td>
        <td></td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.single">float</a></td>
        <td><span class="parametername">value</span></td>
        <td></td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_ChamferEditValue_" data-uid="ElseForty.Splineplus.API.NodeAPI.ChamferEditValue*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_ChamferEditValue_SplinePlus_System_Single_" data-uid="ElseForty.Splineplus.API.NodeAPI.ChamferEditValue(SplinePlus,System.Single)">ChamferEditValue(SplinePlus, float)</h4>
  <div class="markdown level1 summary"></div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static void ChamferEditValue(SplinePlus splinePlus, float value)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">SplinePlus</span></td>
        <td><span class="parametername">splinePlus</span></td>
        <td></td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.single">float</a></td>
        <td><span class="parametername">value</span></td>
        <td></td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_Compound_" data-uid="ElseForty.Splineplus.API.NodeAPI.Compound*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_Compound_SplinePlus_ElseForty_Splineplus_Models_NodeModel_" data-uid="ElseForty.Splineplus.API.NodeAPI.Compound(SplinePlus,ElseForty.splineplus.models.NodeModel)">Compound(SplinePlus, NodeModel)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">Compounds the specified node with the connected branches, merging them into a single branch.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static void Compound(SplinePlus splinePlus, NodeModel node)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">SplinePlus</span></td>
        <td><span class="parametername">splinePlus</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The SplinePlus object containing the spline.</p>
</td>
      </tr>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">node</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The node to be compounded.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_Create_At_Distance_" data-uid="ElseForty.Splineplus.API.NodeAPI.Create_At_Distance*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_Create_At_Distance_SplinePlus_System_Int32_System_Single_" data-uid="ElseForty.Splineplus.API.NodeAPI.Create_At_Distance(SplinePlus,System.Int32,System.Single)">Create_At_Distance(SplinePlus, int, float)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">Creates a new node at a specific distance along the specified branch in the given SplinePlus object.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static NodeModel Create_At_Distance(SplinePlus splinePlus, int branchKey, float distance)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">SplinePlus</span></td>
        <td><span class="parametername">splinePlus</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The SplinePlus object containing the branch.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.int32">int</a></td>
        <td><span class="parametername">branchKey</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The key of the branch on which to create the node.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.single">float</a></td>
        <td><span class="parametername">distance</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The distance along the branch where the new node will be created.</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">The newly created NodeModel object.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_Create_" data-uid="ElseForty.Splineplus.API.NodeAPI.Create*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_Create_SplinePlus_Vector3_" data-uid="ElseForty.Splineplus.API.NodeAPI.Create(SplinePlus,Vector3)">Create(SplinePlus, Vector3)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">Creates a new NodeModel at the specified position for the given SplinePlus object.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static NodeModel Create(SplinePlus splinePlus, Vector3 nodePos)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">SplinePlus</span></td>
        <td><span class="parametername">splinePlus</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The SplinePlus object to which the node will be added.</p>
</td>
      </tr>
      <tr>
        <td><span class="xref">Vector3</span></td>
        <td><span class="parametername">nodePos</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The position of the new node.</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">The newly created NodeModel object.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_Delete_" data-uid="ElseForty.Splineplus.API.NodeAPI.Delete*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_Delete_SplinePlus_ElseForty_Splineplus_Models_NodeModel_" data-uid="ElseForty.Splineplus.API.NodeAPI.Delete(SplinePlus,ElseForty.splineplus.models.NodeModel)">Delete(SplinePlus, NodeModel)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">Deletes the specified node from the spline and removes it from all connected branches.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static void Delete(SplinePlus splinePlus, NodeModel nodeToRemove)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">SplinePlus</span></td>
        <td><span class="parametername">splinePlus</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The SplinePlus object containing the spline.</p>
</td>
      </tr>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">nodeToRemove</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The node to be deleted.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_Diffuse_" data-uid="ElseForty.Splineplus.API.NodeAPI.Diffuse*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_Diffuse_SplinePlus_ElseForty_Splineplus_Models_NodeModel_" data-uid="ElseForty.Splineplus.API.NodeAPI.Diffuse(SplinePlus,ElseForty.splineplus.models.NodeModel)">Diffuse(SplinePlus, NodeModel)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">Diffuses the specified node in the spline, creating a duplicate node on each connected branch and connecting them.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static void Diffuse(SplinePlus splinePlus, NodeModel node)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">SplinePlus</span></td>
        <td><span class="parametername">splinePlus</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The SplinePlus object containing the spline.</p>
</td>
      </tr>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">node</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The node to be diffused.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_Duplicate_" data-uid="ElseForty.Splineplus.API.NodeAPI.Duplicate*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_Duplicate_SplinePlus_ElseForty_Splineplus_Models_NodeModel_" data-uid="ElseForty.Splineplus.API.NodeAPI.Duplicate(SplinePlus,ElseForty.splineplus.models.NodeModel)">Duplicate(SplinePlus, NodeModel)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">Creates a duplicate node based on the specified origin node, copying its properties and positions.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static NodeModel Duplicate(SplinePlus splinePlus, NodeModel originNode)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">SplinePlus</span></td>
        <td><span class="parametername">splinePlus</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The SplinePlus object to which the node belongs.</p>
</td>
      </tr>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">originNode</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The node to duplicate.</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The duplicated node.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_FlipHandles_" data-uid="ElseForty.Splineplus.API.NodeAPI.FlipHandles*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_FlipHandles_ElseForty_Splineplus_Models_NodeModel_" data-uid="ElseForty.Splineplus.API.NodeAPI.FlipHandles(ElseForty.splineplus.models.NodeModel)">FlipHandles(NodeModel)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">Creates a new node with flipped handles based on the provided node, doesn't change the node on the branch</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static NodeModel FlipHandles(NodeModel node)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">node</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The node whose handles will be flipped.</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">A new NodeModel object with flipped handles.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_FlipHandles_" data-uid="ElseForty.Splineplus.API.NodeAPI.FlipHandles*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_FlipHandles_SplinePlus_System_Int32_System_Int32_" data-uid="ElseForty.Splineplus.API.NodeAPI.FlipHandles(SplinePlus,System.Int32,System.Int32)">FlipHandles(SplinePlus, int, int)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">Flips the handles of a node at the specified index in the branch identified by the given key.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static void FlipHandles(SplinePlus splinePlus, int branchKey, int NodeIndex)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">SplinePlus</span></td>
        <td><span class="parametername">splinePlus</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The SplinePlus object containing the branch.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.int32">int</a></td>
        <td><span class="parametername">branchKey</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The key of the branch containing the node.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.int32">int</a></td>
        <td><span class="parametername">NodeIndex</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The index of the node within the branch.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_Fuse_" data-uid="ElseForty.Splineplus.API.NodeAPI.Fuse*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_Fuse_SplinePlus_ElseForty_Splineplus_Models_NodeModel_ElseForty_Splineplus_Models_NodeModel_" data-uid="ElseForty.Splineplus.API.NodeAPI.Fuse(SplinePlus,ElseForty.splineplus.models.NodeModel,ElseForty.splineplus.models.NodeModel)">Fuse(SplinePlus, NodeModel, NodeModel)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">Fuses the origin node with the target node in the specified spline, connecting their branches if necessary.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static void Fuse(SplinePlus splinePlus, NodeModel originNode, NodeModel targetNode)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">SplinePlus</span></td>
        <td><span class="parametername">splinePlus</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The SplinePlus object containing the spline.</p>
</td>
      </tr>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">originNode</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The node to be fused with the target node.</p>
</td>
      </tr>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">targetNode</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The node with which the origin node will be fused.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_Get_Connected_Branches_" data-uid="ElseForty.Splineplus.API.NodeAPI.Get_Connected_Branches*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_Get_Connected_Branches_ElseForty_Splineplus_Models_NodeModel_" data-uid="ElseForty.Splineplus.API.NodeAPI.Get_Connected_Branches(ElseForty.splineplus.models.NodeModel)">Get_Connected_Branches(NodeModel)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">Retrieves a list of branch keys connected to the specified node.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static List&lt;int&gt; Get_Connected_Branches(NodeModel node)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">node</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The node to retrieve connected branches for.</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1">List</a>&lt;<a class="xref" href="https://learn.microsoft.com/dotnet/api/system.int32">int</a>&gt;</td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">A list of branch keys connected to the node.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_Get_Normal_" data-uid="ElseForty.Splineplus.API.NodeAPI.Get_Normal*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_Get_Normal_ElseForty_Splineplus_Models_NodeModel_" data-uid="ElseForty.Splineplus.API.NodeAPI.Get_Normal(ElseForty.splineplus.models.NodeModel)">Get_Normal(NodeModel)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">Gets the normal angle of the specified node.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static float Get_Normal(NodeModel node)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">node</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The node to get the normal angle from.</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.single">float</a></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The normal angle value of the node.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_Get_Handle_1_Position_" data-uid="ElseForty.Splineplus.API.NodeAPI.Get_Handle_1_Position*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_Get_Handle_1_Position_ElseForty_Splineplus_Models_NodeModel_ElseForty_Splineplus_Models_SpaceType_Enum_" data-uid="ElseForty.Splineplus.API.NodeAPI.Get_Handle_1_Position(ElseForty.splineplus.models.NodeModel,ElseForty.splineplus.models.SpaceType_Enum)">Get_Handle_1_Position(NodeModel, SpaceType_Enum)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">Gets the position of the first handle (point1) of the specified node based on the provided space type.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static Vector3 Get_Handle_1_Position(NodeModel node, SpaceType_Enum spaceType)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">node</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The NodeModel object from which to get the first handle's position.</p>
</td>
      </tr>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.SpaceType_Enum</span></td>
        <td><span class="parametername">spaceType</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The space in which the position is requested (local or world).</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">Vector3</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">The position of the first handle (point1) of the node.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_Get_Handle_2_Position_" data-uid="ElseForty.Splineplus.API.NodeAPI.Get_Handle_2_Position*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_Get_Handle_2_Position_ElseForty_Splineplus_Models_NodeModel_ElseForty_Splineplus_Models_SpaceType_Enum_" data-uid="ElseForty.Splineplus.API.NodeAPI.Get_Handle_2_Position(ElseForty.splineplus.models.NodeModel,ElseForty.splineplus.models.SpaceType_Enum)">Get_Handle_2_Position(NodeModel, SpaceType_Enum)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">Gets the position of the second handle (point2) of the specified node based on the provided space type.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static Vector3 Get_Handle_2_Position(NodeModel node, SpaceType_Enum spaceType)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">node</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The NodeModel object from which to get the second handle's position.</p>
</td>
      </tr>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.SpaceType_Enum</span></td>
        <td><span class="parametername">spaceType</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The space in which the position is requested (local or world).</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">Vector3</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">The position of the second handle (point2) of the node.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_Get_Position_" data-uid="ElseForty.Splineplus.API.NodeAPI.Get_Position*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_Get_Position_ElseForty_Splineplus_Models_NodeModel_ElseForty_Splineplus_Models_SpaceType_Enum_" data-uid="ElseForty.Splineplus.API.NodeAPI.Get_Position(ElseForty.splineplus.models.NodeModel,ElseForty.splineplus.models.SpaceType_Enum)">Get_Position(NodeModel, SpaceType_Enum)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">Gets the position of the specified node based on the provided space type.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static Vector3 Get_Position(NodeModel node, SpaceType_Enum spaceType)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">node</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The NodeModel object from which to get the position.</p>
</td>
      </tr>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.SpaceType_Enum</span></td>
        <td><span class="parametername">spaceType</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The space in which the position is requested (local or world).</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">Vector3</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">The position of the node.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_Get_Scale_" data-uid="ElseForty.Splineplus.API.NodeAPI.Get_Scale*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_Get_Scale_ElseForty_Splineplus_Models_NodeModel_" data-uid="ElseForty.Splineplus.API.NodeAPI.Get_Scale(ElseForty.splineplus.models.NodeModel)">Get_Scale(NodeModel)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">Gets the scale of the specified node.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static float Get_Scale(NodeModel node)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">node</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The node to get the scale from.</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.single">float</a></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The scale of the node.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_Get_Speed_" data-uid="ElseForty.Splineplus.API.NodeAPI.Get_Speed*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_Get_Speed_ElseForty_Splineplus_Models_NodeModel_" data-uid="ElseForty.Splineplus.API.NodeAPI.Get_Speed(ElseForty.splineplus.models.NodeModel)">Get_Speed(NodeModel)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">Gets the speed of the specified node.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static float Get_Speed(NodeModel node)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">node</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The node to get the speed from.</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.single">float</a></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The speed of the node.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_Get_Type_" data-uid="ElseForty.Splineplus.API.NodeAPI.Get_Type*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_Get_Type_ElseForty_Splineplus_Models_NodeModel_" data-uid="ElseForty.Splineplus.API.NodeAPI.Get_Type(ElseForty.splineplus.models.NodeModel)">Get_Type(NodeModel)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">Gets the type of the specified node.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static NodeType_Enum Get_Type(NodeModel node)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">node</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The node whose type will be retrieved.</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeType_Enum</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The type of the node.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_Handles_Set_Position_" data-uid="ElseForty.Splineplus.API.NodeAPI.Handles_Set_Position*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_Handles_Set_Position_ElseForty_Splineplus_Models_NodeModel_Vector3_Vector3_ElseForty_Splineplus_Models_SpaceType_Enum_" data-uid="ElseForty.Splineplus.API.NodeAPI.Handles_Set_Position(ElseForty.splineplus.models.NodeModel,Vector3,Vector3,ElseForty.splineplus.models.SpaceType_Enum)">Handles_Set_Position(NodeModel, Vector3, Vector3, SpaceType_Enum)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">Sets the positions of the handles (point1 and point2) of the specified node based on the provided space type.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static void Handles_Set_Position(NodeModel node, Vector3 point1Pos, Vector3 point2Pos, SpaceType_Enum spaceType)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">node</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The NodeModel object whose handles' positions will be set.</p>
</td>
      </tr>
      <tr>
        <td><span class="xref">Vector3</span></td>
        <td><span class="parametername">point1Pos</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The position to set for the first handle (point1).</p>
</td>
      </tr>
      <tr>
        <td><span class="xref">Vector3</span></td>
        <td><span class="parametername">point2Pos</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The position to set for the second handle (point2).</p>
</td>
      </tr>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.SpaceType_Enum</span></td>
        <td><span class="parametername">spaceType</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The space in which the positions are defined (local or world).</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_Is_Shared_" data-uid="ElseForty.Splineplus.API.NodeAPI.Is_Shared*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_Is_Shared_ElseForty_Splineplus_Models_NodeModel_" data-uid="ElseForty.Splineplus.API.NodeAPI.Is_Shared(ElseForty.splineplus.models.NodeModel)">Is_Shared(NodeModel)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">Checks if the specified node is shared among multiple branches.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static bool Is_Shared(NodeModel node)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">node</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The node to check.</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">True if the node is shared among multiple branches, false otherwise.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_Selected_" data-uid="ElseForty.Splineplus.API.NodeAPI.Selected*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_Selected_SplinePlus_" data-uid="ElseForty.Splineplus.API.NodeAPI.Selected(SplinePlus)">Selected(SplinePlus)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">Retrieves the currently selected node from the specified SplinePlus object.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static NodeModel Selected(SplinePlus splinePlus)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">SplinePlus</span></td>
        <td><span class="parametername">splinePlus</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The SplinePlus object from which to retrieve the selected node.</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">The currently selected NodeModel object, or null if no node is selected or the selected node is out of range.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_Set_Normal_" data-uid="ElseForty.Splineplus.API.NodeAPI.Set_Normal*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_Set_Normal_SplinePlus_ElseForty_Splineplus_Models_NodeModel_System_Single_" data-uid="ElseForty.Splineplus.API.NodeAPI.Set_Normal(SplinePlus,ElseForty.splineplus.models.NodeModel,System.Single)">Set_Normal(SplinePlus, NodeModel, float)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">Sets the normal angle of the specified node and updates the connected branches' nodes accordingly.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static void Set_Normal(SplinePlus splinePlus, NodeModel node, float normalAngle)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">SplinePlus</span></td>
        <td><span class="parametername">splinePlus</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The SplinePlus component.</p>
</td>
      </tr>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">node</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The node to set the normal angle for.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.single">float</a></td>
        <td><span class="parametername">normalAngle</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The new normal angle value.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_Set_Position_" data-uid="ElseForty.Splineplus.API.NodeAPI.Set_Position*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_Set_Position_ElseForty_Splineplus_Models_NodeModel_Vector3_ElseForty_Splineplus_Models_SpaceType_Enum_" data-uid="ElseForty.Splineplus.API.NodeAPI.Set_Position(ElseForty.splineplus.models.NodeModel,Vector3,ElseForty.splineplus.models.SpaceType_Enum)">Set_Position(NodeModel, Vector3, SpaceType_Enum)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">Sets the position of the specified node based on the provided space type.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static void Set_Position(NodeModel node, Vector3 nodePos, SpaceType_Enum spaceType)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">node</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The NodeModel object whose position will be set.</p>
</td>
      </tr>
      <tr>
        <td><span class="xref">Vector3</span></td>
        <td><span class="parametername">nodePos</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The position to set for the node.</p>
</td>
      </tr>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.SpaceType_Enum</span></td>
        <td><span class="parametername">spaceType</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The space in which the position is defined (local or world).</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_Set_Scale_" data-uid="ElseForty.Splineplus.API.NodeAPI.Set_Scale*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_Set_Scale_ElseForty_Splineplus_Models_NodeModel_System_Single_" data-uid="ElseForty.Splineplus.API.NodeAPI.Set_Scale(ElseForty.splineplus.models.NodeModel,System.Single)">Set_Scale(NodeModel, float)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">Sets the scale of the specified node.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static void Set_Scale(NodeModel node, float scale)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">node</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The node whose scale will be set.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.single">float</a></td>
        <td><span class="parametername">scale</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The scale value to set.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_Set_Speed_" data-uid="ElseForty.Splineplus.API.NodeAPI.Set_Speed*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_Set_Speed_ElseForty_Splineplus_Models_NodeModel_System_Single_" data-uid="ElseForty.Splineplus.API.NodeAPI.Set_Speed(ElseForty.splineplus.models.NodeModel,System.Single)">Set_Speed(NodeModel, float)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">Sets the speed of movement for the specified node.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static void Set_Speed(NodeModel node, float speed)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">node</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The node whose speed will be set.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.single">float</a></td>
        <td><span class="parametername">speed</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The speed value to set.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_Set_Type_" data-uid="ElseForty.Splineplus.API.NodeAPI.Set_Type*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_Set_Type_ElseForty_Splineplus_Models_NodeModel_ElseForty_Splineplus_Models_NodeType_Enum_" data-uid="ElseForty.Splineplus.API.NodeAPI.Set_Type(ElseForty.splineplus.models.NodeModel,ElseForty.splineplus.models.NodeType_Enum)">Set_Type(NodeModel, NodeType_Enum)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">Sets the type of the specified node.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static void Set_Type(NodeModel node, NodeType_Enum newNodeType)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">node</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The node whose type will be set.</p>
</td>
      </tr>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeType_Enum</span></td>
        <td><span class="parametername">newNodeType</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The new type for the node.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_NodeAPI_Update_" data-uid="ElseForty.Splineplus.API.NodeAPI.Update*"></a>
  <h4 id="ElseForty_Splineplus_API_NodeAPI_Update_SplinePlus_ElseForty_Splineplus_Models_NodeModel_" data-uid="ElseForty.Splineplus.API.NodeAPI.Update(SplinePlus,ElseForty.splineplus.models.NodeModel)">Update(SplinePlus, NodeModel)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="2">Updates the branches connected to the specified node in the given SplinePlus object.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static void Update(SplinePlus splinePlus, NodeModel node)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">SplinePlus</span></td>
        <td><span class="parametername">splinePlus</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The SplinePlus object containing the node and its connected branches.</p>
</td>
      </tr>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">node</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.NodeAPI.yml" sourcestartlinenumber="1">The node whose connected branches need to be updated.</p>
</td>
      </tr>
    </tbody>
  </table>
</article>
          </div>

          <div class="hidden-sm col-md-2" role="complementary">
            <div class="sideaffix">
              <div class="contribution">
                <ul class="nav">
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
