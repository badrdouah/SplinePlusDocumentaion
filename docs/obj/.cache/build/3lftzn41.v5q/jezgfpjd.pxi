<!DOCTYPE html>
<!--[if IE]><![endif]-->
<html>

  <head>
    <meta charset="utf-8">
      <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
      <title>Class BranchAPI
 | Spline Plus documentation </title>
      <meta name="viewport" content="width=device-width">
      <meta name="title" content="Class BranchAPI
 | Spline Plus documentation ">
    
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
            <article class="content wrap" id="_content" data-uid="ElseForty.Splineplus.API.BranchAPI">


  <h1 id="ElseForty_Splineplus_API_BranchAPI" data-uid="ElseForty.Splineplus.API.BranchAPI" class="text-break">Class BranchAPI
</h1>
  <div class="markdown level0 summary"></div>
  <div class="markdown level0 conceptual"></div>
  <div class="inheritance">
    <h5>Inheritance</h5>
    <div class="level0"><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.object">object</a></div>
    <div class="level1"><span class="xref">BranchAPI</span></div>
  </div>
  <h6><strong>Namespace</strong>: <span class="xref">ElseForty</span>.<span class="xref">Splineplus</span>.<a class="xref" href="ElseForty.Splineplus.API.html">API</a></h6>
  <h6><strong>Assembly</strong>: cs.temp.dll.dll</h6>
  <h5 id="ElseForty_Splineplus_API_BranchAPI_syntax">Syntax</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public class BranchAPI</code></pre>
  </div>
  <h3 id="methods">Methods
</h3>


  <a id="ElseForty_Splineplus_API_BranchAPI_Add_Node_At_Index_" data-uid="ElseForty.Splineplus.API.BranchAPI.Add_Node_At_Index*"></a>
  <h4 id="ElseForty_Splineplus_API_BranchAPI_Add_Node_At_Index_SplinePlus_System_Int32_ElseForty_Splineplus_Models_NodeModel_System_Int32_System_Boolean_System_Boolean_" data-uid="ElseForty.Splineplus.API.BranchAPI.Add_Node_At_Index(SplinePlus,System.Int32,ElseForty.splineplus.models.NodeModel,System.Int32,System.Boolean,System.Boolean)">Add_Node_At_Index(SplinePlus, int, NodeModel, int, bool, bool)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="2">Adds a new node at the specified index within the node list of the specified branch in the SplinePlus object.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static void Add_Node_At_Index(SplinePlus splinePlus, int branchKey, NodeModel nodeToAdd, int index, bool doSelect = true, bool autoSmoothHandles = true)</code></pre>
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
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The SplinePlus object containing the spline.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.int32">int</a></td>
        <td><span class="parametername">branchKey</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The key identifying the branch to which the node will be added.</p>
</td>
      </tr>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">nodeToAdd</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The NodeModel representing the node to add.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.int32">int</a></td>
        <td><span class="parametername">index</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The index at which the node will be inserted within the branch's node list.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
        <td><span class="parametername">doSelect</span></td>
        <td></td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
        <td><span class="parametername">autoSmoothHandles</span></td>
        <td></td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_BranchAPI_Add_Node_Beginning_" data-uid="ElseForty.Splineplus.API.BranchAPI.Add_Node_Beginning*"></a>
  <h4 id="ElseForty_Splineplus_API_BranchAPI_Add_Node_Beginning_SplinePlus_System_Int32_ElseForty_Splineplus_Models_NodeModel_System_Boolean_System_Boolean_" data-uid="ElseForty.Splineplus.API.BranchAPI.Add_Node_Beginning(SplinePlus,System.Int32,ElseForty.splineplus.models.NodeModel,System.Boolean,System.Boolean)">Add_Node_Beginning(SplinePlus, int, NodeModel, bool, bool)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="2">Adds a new node at the beginning of the specified branch in the SplinePlus object.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static void Add_Node_Beginning(SplinePlus splinePlus, int branchKey, NodeModel nodeToAdd, bool doSelect = true, bool autoSmoothHandles = true)</code></pre>
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
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The SplinePlus object containing the spline.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.int32">int</a></td>
        <td><span class="parametername">branchKey</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The key identifying the branch to which the node will be added.</p>
</td>
      </tr>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">nodeToAdd</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The NodeModel representing the node to add.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
        <td><span class="parametername">doSelect</span></td>
        <td></td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
        <td><span class="parametername">autoSmoothHandles</span></td>
        <td></td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_BranchAPI_Add_Node_End_" data-uid="ElseForty.Splineplus.API.BranchAPI.Add_Node_End*"></a>
  <h4 id="ElseForty_Splineplus_API_BranchAPI_Add_Node_End_SplinePlus_System_Int32_ElseForty_Splineplus_Models_NodeModel_System_Boolean_System_Boolean_" data-uid="ElseForty.Splineplus.API.BranchAPI.Add_Node_End(SplinePlus,System.Int32,ElseForty.splineplus.models.NodeModel,System.Boolean,System.Boolean)">Add_Node_End(SplinePlus, int, NodeModel, bool, bool)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="2">Adds a new node at the end of the specified branch in the SplinePlus object.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static void Add_Node_End(SplinePlus splinePlus, int branchKey, NodeModel nodeToAdd, bool doSelect = true, bool autoSmoothHandles = true)</code></pre>
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
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The SplinePlus object containing the spline.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.int32">int</a></td>
        <td><span class="parametername">branchKey</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The key identifying the branch to which the node will be added.</p>
</td>
      </tr>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">nodeToAdd</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The NodeModel representing the node to add.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
        <td><span class="parametername">doSelect</span></td>
        <td></td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
        <td><span class="parametername">autoSmoothHandles</span></td>
        <td></td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_BranchAPI_Break_" data-uid="ElseForty.Splineplus.API.BranchAPI.Break*"></a>
  <h4 id="ElseForty_Splineplus_API_BranchAPI_Break_SplinePlus_ElseForty_Splineplus_Models_NodeModel_" data-uid="ElseForty.Splineplus.API.BranchAPI.Break(SplinePlus,ElseForty.splineplus.models.NodeModel)">Break(SplinePlus, NodeModel)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="2">Breaks a spline branch at the specified node, creating a new branch starting from that node.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static void Break(SplinePlus splinePlus, NodeModel node)</code></pre>
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
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The SplinePlus object containing the spline.</p>
</td>
      </tr>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">node</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The node at which to break the spline branch.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_BranchAPI_Clean_" data-uid="ElseForty.Splineplus.API.BranchAPI.Clean*"></a>
  <h4 id="ElseForty_Splineplus_API_BranchAPI_Clean_SplinePlus_" data-uid="ElseForty.Splineplus.API.BranchAPI.Clean(SplinePlus)">Clean(SplinePlus)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="2">Removes branches from a SplinePlus object that contain only one node.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static void Clean(SplinePlus splinePlus)</code></pre>
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
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The SplinePlus object to be cleaned.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_BranchAPI_Create_" data-uid="ElseForty.Splineplus.API.BranchAPI.Create*"></a>
  <h4 id="ElseForty_Splineplus_API_BranchAPI_Create_SplinePlus_System_Boolean_" data-uid="ElseForty.Splineplus.API.BranchAPI.Create(SplinePlus,System.Boolean)">Create(SplinePlus, bool)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="2">Creates a new branch in the specified SplinePlus object and returns its key.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static int Create(SplinePlus splinePlus, bool doSelect = true)</code></pre>
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
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The SplinePlus object to which the new branch will be added.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
        <td><span class="parametername">doSelect</span></td>
        <td></td>
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
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.int32">int</a></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The key of the newly created branch.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_BranchAPI_Delete_" data-uid="ElseForty.Splineplus.API.BranchAPI.Delete*"></a>
  <h4 id="ElseForty_Splineplus_API_BranchAPI_Delete_SplinePlus_System_Int32_" data-uid="ElseForty.Splineplus.API.BranchAPI.Delete(SplinePlus,System.Int32)">Delete(SplinePlus, int)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="2">Deletes the specified branch from the SplinePlus object.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static void Delete(SplinePlus splinePlus, int branchKey)</code></pre>
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
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The SplinePlus object containing the spline.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.int32">int</a></td>
        <td><span class="parametername">branchKey</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The key identifying the branch to be deleted.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_BranchAPI_Diffuse_" data-uid="ElseForty.Splineplus.API.BranchAPI.Diffuse*"></a>
  <h4 id="ElseForty_Splineplus_API_BranchAPI_Diffuse_SplinePlus_System_Int32_" data-uid="ElseForty.Splineplus.API.BranchAPI.Diffuse(SplinePlus,System.Int32)">Diffuse(SplinePlus, int)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="2">Diffuses shared nodes in a specific branch of a SplinePlus object.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static void Diffuse(SplinePlus splinePlus, int branchKey)</code></pre>
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
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The SplinePlus object containing the branch with shared nodes to be diffused.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.int32">int</a></td>
        <td><span class="parametername">branchKey</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">An integer representing the key of the branch to be processed.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_BranchAPI_Fix_ConnectedBranches_" data-uid="ElseForty.Splineplus.API.BranchAPI.Fix_ConnectedBranches*"></a>
  <h4 id="ElseForty_Splineplus_API_BranchAPI_Fix_ConnectedBranches_SplinePlus_" data-uid="ElseForty.Splineplus.API.BranchAPI.Fix_ConnectedBranches(SplinePlus)">Fix_ConnectedBranches(SplinePlus)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="2">Fixes the connected branches of shared nodes in a SplinePlus object.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static void Fix_ConnectedBranches(SplinePlus splinePlus)</code></pre>
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
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The SplinePlus object whose shared nodes' connected branches need to be fixed.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_BranchAPI_Get_Length_" data-uid="ElseForty.Splineplus.API.BranchAPI.Get_Length*"></a>
  <h4 id="ElseForty_Splineplus_API_BranchAPI_Get_Length_SplinePlus_System_Int32_" data-uid="ElseForty.Splineplus.API.BranchAPI.Get_Length(SplinePlus,System.Int32)">Get_Length(SplinePlus, int)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="2">Calculates and returns the length of a branch in a SplinePlus object.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static float Get_Length(SplinePlus splinePlus, int branchKey)</code></pre>
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
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The SplinePlus object containing the branch.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.int32">int</a></td>
        <td><span class="parametername">branchKey</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">An integer representing the key of the branch.</p>
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
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="2">The length of the specified branch as a floating-point number.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_BranchAPI_Get_Nodes_" data-uid="ElseForty.Splineplus.API.BranchAPI.Get_Nodes*"></a>
  <h4 id="ElseForty_Splineplus_API_BranchAPI_Get_Nodes_SplinePlus_System_Int32_" data-uid="ElseForty.Splineplus.API.BranchAPI.Get_Nodes(SplinePlus,System.Int32)">Get_Nodes(SplinePlus, int)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="2">Retrieves the list of nodes belonging to the specified branch in the SplinePlus object.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static List&lt;NodeModel&gt; Get_Nodes(SplinePlus splinePlus, int branchKey)</code></pre>
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
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The SplinePlus object containing the spline.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.int32">int</a></td>
        <td><span class="parametername">branchKey</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The key identifying the branch whose nodes will be retrieved.</p>
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
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1">List</a>&lt;<span class="xref">ElseForty.splineplus.models.NodeModel</span>&gt;</td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The list of NodeModel objects representing the nodes of the specified branch, or null if the branch does not exist.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_BranchAPI_Get_Normals_" data-uid="ElseForty.Splineplus.API.BranchAPI.Get_Normals*"></a>
  <h4 id="ElseForty_Splineplus_API_BranchAPI_Get_Normals_SplinePlus_System_Int32_" data-uid="ElseForty.Splineplus.API.BranchAPI.Get_Normals(SplinePlus,System.Int32)">Get_Normals(SplinePlus, int)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="2">Retrieves the normals of a branch in a SplinePlus object.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static List&lt;Vector3&gt; Get_Normals(SplinePlus splinePlus, int branchKey)</code></pre>
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
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The SplinePlus object containing the branch.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.int32">int</a></td>
        <td><span class="parametername">branchKey</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">An integer representing the key of the branch.</p>
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
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1">List</a>&lt;<span class="xref">Vector3</span>&gt;</td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="2">A list of Vector3 objects representing the normals of the specified branch.
Returns null if the branch with the specified key is not found.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_BranchAPI_Get_Tangents_" data-uid="ElseForty.Splineplus.API.BranchAPI.Get_Tangents*"></a>
  <h4 id="ElseForty_Splineplus_API_BranchAPI_Get_Tangents_SplinePlus_System_Int32_" data-uid="ElseForty.Splineplus.API.BranchAPI.Get_Tangents(SplinePlus,System.Int32)">Get_Tangents(SplinePlus, int)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="2">Retrieves the tangents of a branch in a SplinePlus object.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static List&lt;Vector3&gt; Get_Tangents(SplinePlus splinePlus, int branchKey)</code></pre>
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
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The SplinePlus object containing the branch.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.int32">int</a></td>
        <td><span class="parametername">branchKey</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">An integer representing the key of the branch.</p>
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
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1">List</a>&lt;<span class="xref">Vector3</span>&gt;</td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="2">A list of Vector3 objects representing the tangents of the specified branch.
Returns null if the branch with the specified key is not found.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_BranchAPI_Get_Vertices_" data-uid="ElseForty.Splineplus.API.BranchAPI.Get_Vertices*"></a>
  <h4 id="ElseForty_Splineplus_API_BranchAPI_Get_Vertices_SplinePlus_System_Int32_" data-uid="ElseForty.Splineplus.API.BranchAPI.Get_Vertices(SplinePlus,System.Int32)">Get_Vertices(SplinePlus, int)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="2">Retrieves the vertices of a branch in a SplinePlus object.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static List&lt;Vector3&gt; Get_Vertices(SplinePlus splinePlus, int branchKey)</code></pre>
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
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The SplinePlus object containing the branch.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.int32">int</a></td>
        <td><span class="parametername">branchKey</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">An integer representing the key of the branch.</p>
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
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1">List</a>&lt;<span class="xref">Vector3</span>&gt;</td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="2">A list of Vector3 objects representing the vertices of the specified branch.
Returns null if the branch with the specified key is not found.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_BranchAPI_Merge_" data-uid="ElseForty.Splineplus.API.BranchAPI.Merge*"></a>
  <h4 id="ElseForty_Splineplus_API_BranchAPI_Merge_SplinePlus_System_Int32_System_Int32_" data-uid="ElseForty.Splineplus.API.BranchAPI.Merge(SplinePlus,System.Int32,System.Int32)">Merge(SplinePlus, int, int)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="2">Merges two branches of a SplinePlus object into one branch.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static int Merge(SplinePlus splinePlus, int branchKey1, int branchKey2)</code></pre>
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
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The SplinePlus object containing the branches to be merged.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.int32">int</a></td>
        <td><span class="parametername">branchKey1</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">An integer representing the key of the first branch to be merged.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.int32">int</a></td>
        <td><span class="parametername">branchKey2</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">An integer representing the key of the second branch to be merged.</p>
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
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.int32">int</a></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="2">An integer representing the key of the merged branch.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_BranchAPI_Replace_Node_At_Index_" data-uid="ElseForty.Splineplus.API.BranchAPI.Replace_Node_At_Index*"></a>
  <h4 id="ElseForty_Splineplus_API_BranchAPI_Replace_Node_At_Index_SplinePlus_System_Int32_ElseForty_Splineplus_Models_NodeModel_System_Int32_System_Boolean_System_Boolean_" data-uid="ElseForty.Splineplus.API.BranchAPI.Replace_Node_At_Index(SplinePlus,System.Int32,ElseForty.splineplus.models.NodeModel,System.Int32,System.Boolean,System.Boolean)">Replace_Node_At_Index(SplinePlus, int, NodeModel, int, bool, bool)</h4>
  <div class="markdown level1 summary"></div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static void Replace_Node_At_Index(SplinePlus splinePlus, int branchKey, NodeModel nodeToReplace, int index, bool doSelect = true, bool autoSmoothHandles = true)</code></pre>
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
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.int32">int</a></td>
        <td><span class="parametername">branchKey</span></td>
        <td></td>
      </tr>
      <tr>
        <td><span class="xref">ElseForty.splineplus.models.NodeModel</span></td>
        <td><span class="parametername">nodeToReplace</span></td>
        <td></td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.int32">int</a></td>
        <td><span class="parametername">index</span></td>
        <td></td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
        <td><span class="parametername">doSelect</span></td>
        <td></td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a></td>
        <td><span class="parametername">autoSmoothHandles</span></td>
        <td></td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_BranchAPI_Reverse_" data-uid="ElseForty.Splineplus.API.BranchAPI.Reverse*"></a>
  <h4 id="ElseForty_Splineplus_API_BranchAPI_Reverse_SplinePlus_System_Int32_" data-uid="ElseForty.Splineplus.API.BranchAPI.Reverse(SplinePlus,System.Int32)">Reverse(SplinePlus, int)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="2">Reverses the order of nodes in a specific branch of a SplinePlus object and flips the handles for each node.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static void Reverse(SplinePlus splinePlus, int branchKey)</code></pre>
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
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The SplinePlus object containing the branch to be reversed.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.int32">int</a></td>
        <td><span class="parametername">branchKey</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">An integer representing the key of the branch to be reversed.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_BranchAPI_Selected_" data-uid="ElseForty.Splineplus.API.BranchAPI.Selected*"></a>
  <h4 id="ElseForty_Splineplus_API_BranchAPI_Selected_SplinePlus_" data-uid="ElseForty.Splineplus.API.BranchAPI.Selected(SplinePlus)">Selected(SplinePlus)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="2">Retrieves the currently selected branch from the specified SplinePlus object.
If no branch is selected, creates a new branch and sets it as selected.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static BranchModel Selected(SplinePlus splinePlus)</code></pre>
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
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The SplinePlus object containing the spline.</p>
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
        <td><span class="xref">ElseForty.splineplus.models.BranchModel</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The currently selected branch, or null if no branch is found.</p>
</td>
      </tr>
    </tbody>
  </table>


  <a id="ElseForty_Splineplus_API_BranchAPI_Update_" data-uid="ElseForty.Splineplus.API.BranchAPI.Update*"></a>
  <h4 id="ElseForty_Splineplus_API_BranchAPI_Update_SplinePlus_System_Int32_" data-uid="ElseForty.Splineplus.API.BranchAPI.Update(SplinePlus,System.Int32)">Update(SplinePlus, int)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="2">Updates the geometry and properties of a specific branch of the spline.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="declaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public static void Update(SplinePlus splinePlus, int branchKey)</code></pre>
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
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The SplinePlus object containing the spline.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.int32">int</a></td>
        <td><span class="parametername">branchKey</span></td>
        <td><p sourcefile="api/ElseForty.Splineplus.API.BranchAPI.yml" sourcestartlinenumber="1">The key identifying the branch to update.</p>
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
