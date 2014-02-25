<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" Inherits="YAF.ForumPageBase" %>
<%@ Register TagPrefix="YAF" Assembly="YAF" Namespace="YAF" %>
<script runat="server">
	
</script>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="YafHead" runat="server">
    <meta id="YafMetaScriptingLanguage" http-equiv="Content-Script-Type" runat="server"
        name="scriptlanguage" content="text/javascript" />
    <meta id="YafMetaStyles" http-equiv="Content-Style-Type" runat="server" name="styles"
        content="text/css" />
    <meta id="YafMetaDescription" runat="server" name="description" content="A site made for Märklin model train users by users, lots of info on digital, model reviews and more marklin info. You also find the best and biggest international Märklin discussion forum community here with members from all over the world." />
    <meta id="YafMetaKeywords" runat="server" name="keywords" content="Marklin, Märklin, Maerklin, marklin, maerklin, märklin, trains, ,train, forum, model, train, models, modelle, zug, H0, modellbahn, railroad, Digital, digital, users, delta, graphics, poster" />
<meta name="TITLE" content="marklin-users.net - For Märklin users who like to play with Märklin model trains ">
<meta name="DESCRIPTION" content="A site made for M&auml;rklin model train users by users, lots of info on digital, model reviews and more marklin info. You also find the best and biggest international Märklin discussion forum community here with members from all over the world. ">
<meta name="KEYWORDS" content="Marklin, Märklin, Maerklin,M&auml;rklin, m&auml;rklin marklin, maerklin, märklin, trains, ,train, forum, model, train, models, modelle, zug, H0, modellbahn, railroad, Digital, digital, users, delta, graphics, poster, system, community">
<meta name="OWNER" content="Juhan Palm">
<meta name="AUTHOR" content="Members of the community, thousands of Märklin enthusiasts">
<meta content="UTF-8">
<meta content="English">
<meta content="Homepage">
<meta name="RATING" content="General">
<meta name="ROBOTS" content="index,follow">
<meta name="REVISIT-AFTER" content="1 weeks">

    <title>marklin-users.net forum - for m&auml;rklin model train users</title>
<style type=text/css>
body {

	background-color: #e3e3e3;
	background: -o-linear-gradient(linear, left top, left bottom, from(#333333), to(#eeeeee));	
	background: -webkit-gradient(linear, left top, left bottom, from(#333333), to(#eeeeee));
	background: -moz-linear-gradient(top,  #333333,  #eeeeee);
	background: -ms-linear-gradient(top,  #333333,  #eeeeee);  /* IE10+ */
	background: linear-gradient(top, #333333,  #eeeeee);  /* W3C */
	filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#333333', endColorstr='#eeeeee',GradientType=0 );  /* IE6-9 */

}

#mu_menu {
width:100%;
	height:auto;
	
margin-left:0;
	margin-right:0;
	padding-top:0;
	padding-bottom:0px;
	text-align:center;
   /* background-color: #444444; */
}


div#mu_menu ul{
	float:none;
	height:auto;
	overflow:auto;
	margin-left: 10px;
     font: 12px Verdana, Arial, sans-serif; 
	padding:0;
}

div#mu_menu ul li{
	display:inline;
	overflow:auto;
}

div#mu_menu ul li a{
	display:block;
	float:left;
	height:16px;
	white-space:nowrap;
	margin-right:0px;
	margin-top:2px;
	margin-bottom:3px;
	padding-right:10px;
    padding-left:10px;
	padding-top:0;
	padding-bottom:0;
	border-right: solid 1px #888888;
	text-decoration:none;
	color:#cccccc;
	font-weight:bold;
    }

div#mu_menu ul li a:link  { color: #cccccc; text-decoration: none } 
div#mu_menu ul li a:visited   { color: #cccccc ; text-decoration: none} 
div#mu_menu ul li a:hover      { color: #cc0000; text-decoration: none;border-bottom:1px outset #cccccc; }

</style>




<script type="text/javascript">

    var _gaq = _gaq || [];
    _gaq.push(['_setAccount', 'UA-21530838-1']);
    _gaq.push(['_trackPageview']);

    (function () {
        var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
        ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
        var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
    })();

</script>
</head>
<body  TOPMARGIN=0 LEFTMARGIN=0 RIGHTMARGIN=0 MARGINHEIGHT=0 MARGINWIDTH=0>
<table style="width: 100%" cellpadding="0" cellspacing="0" >
		<tr>
			
<td "style="height: 60px;">
			<font color="#cccccc" face="arial" size=6 >&nbsp;
			marklin-users.net community forum</font><font color="#dddddd" face="verdana" size=2 ><br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;- the best place to meet fellow model train users</font></td>

       
			<td style="height: 60px; width: 160px; ;">
			<font color="#ffffff" face="Verdana" size="2">
            <a href="../../../" >
			<img border=0 style="height="37"; align="middle" src="../images/munlogo.jpg" width="155" /></a>&nbsp;</td>
            
		</tr>
<tr>
 <td colspan=3 style="height: 15px; background-image: url('/images/web.png');"></td>
</tr>
</table>
<div id="mu_menu">
<ul> 
  <li><a href="../../">Home</a></li> 
  <li><a href="../../notavailable.cshtml">Articles</a></li> 
  <li><a href="../../notavailable.cshtml">Reviews</a></li> 
   <li><a href="../../notavailable.cshtml">Member features</a></li> 
  <li><a href="../../notavailable.cshtml">Blogs</a></li>
 <li><a href="../../notavailable.cshtml">da Wiki</a></li> 
 <li><a href="../../notavailable.cshtml">muTube</a></li>   
  <li><a href="../../forum">Community Forum</a></li> 
    </ul></div>
   <table width=97% bgcolor= "#fcfcfc" align=center bordercolor="#333333">
<tr><td>

    <form id="form1" runat="server" enctype="multipart/form-data" width="90%">
    <YAF:Forum runat="server" ID="forum" BoardID="1">
    </YAF:Forum>
    </form>
</td></tr>
</table>


<br/>
<Table width=100% bgcolor="#444444">
<tr> 
<td width=25% align=center valign=top>
></td>
<td width=25% align=center valign=top><font color="#cccccc" face="Verdana" size="1"></td>

<td width=25% align=center valign=top>
<font color="#cccccc" face="Verdana" size="1"><br /><span id="siteseal">
<script type="text/javascript" src="https://seal.godaddy.com/getSeal?sealID=aerwJ9sRnzFVqvz8uwTrOiDLREGYI6wXbUmtselq9ewRYBt8IsCJZZFu3PA1"></script><br/>
<a style="font-family: arial; font-size: 9px Font-color:#cccccc" href="https://www.godaddy.com/ssl/ssl-certificates.aspx" target="_blank">ssl certificates</a></span>
</td>


<td widhth=25% align=center valign=top>
<font color="#cccccc" face="Verdana" size="1"><b>Donate to marklin-users.net website operation</b></font><br>&nbsp;<br>
<form action="https://www.paypal.com/cgi-bin/webscr" method="post">
<input type="hidden" name="cmd" value="_s-xclick">
<input type="hidden" name="hosted_button_id" value="YWYTU57LNJNCE">
<input type="image" src="https://www.paypalobjects.com/WEBSCR-640-20110306-1/en_GB/i/btn/btn_donate_SM.gif" border="0" name="submit" alt="PayPal - The safer, easier way to pay online.">
<img alt="" border="0" src="https://www.paypalobjects.com/WEBSCR-640-20110306-1/en_US/i/scr/pixel.gif" width="1" height="1">
</form>

</td>

</tr>
</Table>



</body>
</html>
