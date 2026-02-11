using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000022 RID: 34
	public class Clipper : ClipperBase
	{
		// Token: 0x06000195 RID: 405 RVA: 0x0001A89C File Offset: 0x00018A9C
		// Note: this type is marked as 'beforefieldinit'.
		static Clipper()
		{
			Il2CppClassPointerStore<Clipper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "Clipper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Clipper>.NativeClassPtr);
			Clipper.NativeFieldInfoPtr_ioReverseSolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clipper>.NativeClassPtr, "ioReverseSolution");
			Clipper.NativeFieldInfoPtr_ioStrictlySimple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clipper>.NativeClassPtr, "ioStrictlySimple");
			Clipper.NativeFieldInfoPtr_ioPreserveCollinear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clipper>.NativeClassPtr, "ioPreserveCollinear");
			Clipper.NativeFieldInfoPtr_m_ClipType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clipper>.NativeClassPtr, "m_ClipType");
			Clipper.NativeFieldInfoPtr_m_Maxima = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clipper>.NativeClassPtr, "m_Maxima");
			Clipper.NativeFieldInfoPtr_m_SortedEdges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clipper>.NativeClassPtr, "m_SortedEdges");
			Clipper.NativeFieldInfoPtr_m_IntersectList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clipper>.NativeClassPtr, "m_IntersectList");
			Clipper.NativeFieldInfoPtr_m_IntersectNodeComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clipper>.NativeClassPtr, "m_IntersectNodeComparer");
			Clipper.NativeFieldInfoPtr_m_ExecuteLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clipper>.NativeClassPtr, "m_ExecuteLocked");
			Clipper.NativeFieldInfoPtr_m_ClipFillType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clipper>.NativeClassPtr, "m_ClipFillType");
			Clipper.NativeFieldInfoPtr_m_SubjFillType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clipper>.NativeClassPtr, "m_SubjFillType");
			Clipper.NativeFieldInfoPtr_m_Joins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clipper>.NativeClassPtr, "m_Joins");
			Clipper.NativeFieldInfoPtr_m_GhostJoins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clipper>.NativeClassPtr, "m_GhostJoins");
			Clipper.NativeFieldInfoPtr_m_UsingPolyTree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clipper>.NativeClassPtr, "m_UsingPolyTree");
			Clipper.NativeFieldInfoPtr__LastIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clipper>.NativeClassPtr, "<LastIndex>k__BackingField");
			Clipper.NativeFieldInfoPtr__ReverseSolution_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clipper>.NativeClassPtr, "<ReverseSolution>k__BackingField");
			Clipper.NativeFieldInfoPtr__StrictlySimple_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clipper>.NativeClassPtr, "<StrictlySimple>k__BackingField");
			Clipper.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663474);
			Clipper.NativeMethodInfoPtr_InsertMaxima_Private_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663475);
			Clipper.NativeMethodInfoPtr_get_LastIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663476);
			Clipper.NativeMethodInfoPtr_set_LastIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663477);
			Clipper.NativeMethodInfoPtr_get_ReverseSolution_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663478);
			Clipper.NativeMethodInfoPtr_set_ReverseSolution_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663479);
			Clipper.NativeMethodInfoPtr_get_StrictlySimple_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663480);
			Clipper.NativeMethodInfoPtr_set_StrictlySimple_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663481);
			Clipper.NativeMethodInfoPtr_Execute_Public_Boolean_ClipType_List_1_List_1_IntPoint_PolyFillType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663482);
			Clipper.NativeMethodInfoPtr_Execute_Public_Boolean_ClipType_PolyTree_PolyFillType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663483);
			Clipper.NativeMethodInfoPtr_Execute_Public_Boolean_ClipType_List_1_List_1_IntPoint_PolyFillType_PolyFillType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663484);
			Clipper.NativeMethodInfoPtr_Execute_Public_Boolean_ClipType_PolyTree_PolyFillType_PolyFillType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663485);
			Clipper.NativeMethodInfoPtr_FixHoleLinkage_Internal_Void_OutRec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663486);
			Clipper.NativeMethodInfoPtr_ExecuteInternal_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663487);
			Clipper.NativeMethodInfoPtr_DisposeAllPolyPts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663488);
			Clipper.NativeMethodInfoPtr_AddJoin_Private_Void_OutPt_OutPt_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663489);
			Clipper.NativeMethodInfoPtr_AddGhostJoin_Private_Void_OutPt_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663490);
			Clipper.NativeMethodInfoPtr_InsertLocalMinimaIntoAEL_Private_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663491);
			Clipper.NativeMethodInfoPtr_InsertEdgeIntoAEL_Private_Void_TEdge_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663492);
			Clipper.NativeMethodInfoPtr_E2InsertsBeforeE1_Private_Boolean_TEdge_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663493);
			Clipper.NativeMethodInfoPtr_IsEvenOddFillType_Private_Boolean_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663494);
			Clipper.NativeMethodInfoPtr_IsEvenOddAltFillType_Private_Boolean_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663495);
			Clipper.NativeMethodInfoPtr_IsContributing_Private_Boolean_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663496);
			Clipper.NativeMethodInfoPtr_SetWindingCount_Private_Void_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663497);
			Clipper.NativeMethodInfoPtr_AddEdgeToSEL_Private_Void_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663498);
			Clipper.NativeMethodInfoPtr_PopEdgeFromSEL_Internal_Boolean_byref_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663499);
			Clipper.NativeMethodInfoPtr_CopyAELToSEL_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663500);
			Clipper.NativeMethodInfoPtr_SwapPositionsInSEL_Private_Void_TEdge_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663501);
			Clipper.NativeMethodInfoPtr_AddLocalMaxPoly_Private_Void_TEdge_TEdge_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663502);
			Clipper.NativeMethodInfoPtr_AddLocalMinPoly_Private_OutPt_TEdge_TEdge_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663503);
			Clipper.NativeMethodInfoPtr_AddOutPt_Private_OutPt_TEdge_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663504);
			Clipper.NativeMethodInfoPtr_GetLastOutPt_Private_OutPt_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663505);
			Clipper.NativeMethodInfoPtr_SwapPoints_Internal_Void_byref_IntPoint_byref_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663506);
			Clipper.NativeMethodInfoPtr_HorzSegmentsOverlap_Private_Boolean_Int64_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663507);
			Clipper.NativeMethodInfoPtr_SetHoleState_Private_Void_TEdge_OutRec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663508);
			Clipper.NativeMethodInfoPtr_GetDx_Private_Double_IntPoint_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663509);
			Clipper.NativeMethodInfoPtr_FirstIsBottomPt_Private_Boolean_OutPt_OutPt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663510);
			Clipper.NativeMethodInfoPtr_GetBottomPt_Private_OutPt_OutPt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663511);
			Clipper.NativeMethodInfoPtr_GetLowermostRec_Private_OutRec_OutRec_OutRec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663512);
			Clipper.NativeMethodInfoPtr_OutRec1RightOfOutRec2_Private_Boolean_OutRec_OutRec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663513);
			Clipper.NativeMethodInfoPtr_GetOutRec_Private_OutRec_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663514);
			Clipper.NativeMethodInfoPtr_AppendPolygon_Private_Void_TEdge_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663515);
			Clipper.NativeMethodInfoPtr_ReversePolyPtLinks_Private_Void_OutPt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663516);
			Clipper.NativeMethodInfoPtr_SwapSides_Private_Static_Void_TEdge_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663517);
			Clipper.NativeMethodInfoPtr_SwapPolyIndexes_Private_Static_Void_TEdge_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663518);
			Clipper.NativeMethodInfoPtr_IntersectEdges_Private_Void_TEdge_TEdge_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663519);
			Clipper.NativeMethodInfoPtr_DeleteFromSEL_Private_Void_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663520);
			Clipper.NativeMethodInfoPtr_ProcessHorizontals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663521);
			Clipper.NativeMethodInfoPtr_GetHorzDirection_Private_Void_TEdge_byref_Direction_byref_Int64_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663522);
			Clipper.NativeMethodInfoPtr_ProcessHorizontal_Private_Void_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663523);
			Clipper.NativeMethodInfoPtr_GetNextInAEL_Private_TEdge_TEdge_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663524);
			Clipper.NativeMethodInfoPtr_IsMinima_Private_Boolean_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663525);
			Clipper.NativeMethodInfoPtr_IsMaxima_Private_Boolean_TEdge_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663526);
			Clipper.NativeMethodInfoPtr_IsIntermediate_Private_Boolean_TEdge_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663527);
			Clipper.NativeMethodInfoPtr_GetMaximaPair_Internal_TEdge_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663528);
			Clipper.NativeMethodInfoPtr_GetMaximaPairEx_Internal_TEdge_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663529);
			Clipper.NativeMethodInfoPtr_ProcessIntersections_Private_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663530);
			Clipper.NativeMethodInfoPtr_BuildIntersectList_Private_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663531);
			Clipper.NativeMethodInfoPtr_EdgesAdjacent_Private_Boolean_IntersectNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663532);
			Clipper.NativeMethodInfoPtr_IntersectNodeSort_Private_Static_Int32_IntersectNode_IntersectNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663533);
			Clipper.NativeMethodInfoPtr_FixupIntersectionOrder_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663534);
			Clipper.NativeMethodInfoPtr_ProcessIntersectList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663535);
			Clipper.NativeMethodInfoPtr_Round_Internal_Static_Int64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663536);
			Clipper.NativeMethodInfoPtr_TopX_Private_Static_Int64_TEdge_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663537);
			Clipper.NativeMethodInfoPtr_IntersectPoint_Private_Void_TEdge_TEdge_byref_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663538);
			Clipper.NativeMethodInfoPtr_ProcessEdgesAtTopOfScanbeam_Private_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663539);
			Clipper.NativeMethodInfoPtr_DoMaxima_Private_Void_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663540);
			Clipper.NativeMethodInfoPtr_ReversePaths_Public_Static_Void_List_1_List_1_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663541);
			Clipper.NativeMethodInfoPtr_Orientation_Public_Static_Boolean_List_1_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663542);
			Clipper.NativeMethodInfoPtr_PointCount_Private_Int32_OutPt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663543);
			Clipper.NativeMethodInfoPtr_BuildResult_Private_Void_List_1_List_1_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663544);
			Clipper.NativeMethodInfoPtr_BuildResult2_Private_Void_PolyTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663545);
			Clipper.NativeMethodInfoPtr_FixupOutPolyline_Private_Void_OutRec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663546);
			Clipper.NativeMethodInfoPtr_FixupOutPolygon_Private_Void_OutRec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663547);
			Clipper.NativeMethodInfoPtr_DupOutPt_Private_OutPt_OutPt_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663548);
			Clipper.NativeMethodInfoPtr_GetOverlap_Private_Boolean_Int64_Int64_Int64_Int64_byref_Int64_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663549);
			Clipper.NativeMethodInfoPtr_JoinHorz_Private_Boolean_OutPt_OutPt_OutPt_OutPt_IntPoint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663550);
			Clipper.NativeMethodInfoPtr_JoinPoints_Private_Boolean_Join_OutRec_OutRec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663551);
			Clipper.NativeMethodInfoPtr_PointInPolygon_Public_Static_Int32_IntPoint_List_1_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663552);
			Clipper.NativeMethodInfoPtr_PointInPolygon_Private_Static_Int32_IntPoint_OutPt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663553);
			Clipper.NativeMethodInfoPtr_Poly2ContainsPoly1_Private_Static_Boolean_OutPt_OutPt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663554);
			Clipper.NativeMethodInfoPtr_FixupFirstLefts1_Private_Void_OutRec_OutRec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663555);
			Clipper.NativeMethodInfoPtr_FixupFirstLefts2_Private_Void_OutRec_OutRec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663556);
			Clipper.NativeMethodInfoPtr_FixupFirstLefts3_Private_Void_OutRec_OutRec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663557);
			Clipper.NativeMethodInfoPtr_ParseFirstLeft_Private_Static_OutRec_OutRec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663558);
			Clipper.NativeMethodInfoPtr_JoinCommonEdges_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663559);
			Clipper.NativeMethodInfoPtr_UpdateOutPtIdxs_Private_Void_OutRec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663560);
			Clipper.NativeMethodInfoPtr_DoSimplePolygons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663561);
			Clipper.NativeMethodInfoPtr_Area_Public_Static_Double_List_1_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663562);
			Clipper.NativeMethodInfoPtr_Area_Internal_Double_OutRec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663563);
			Clipper.NativeMethodInfoPtr_Area_Internal_Double_OutPt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663564);
			Clipper.NativeMethodInfoPtr_SimplifyPolygon_Public_Static_List_1_List_1_IntPoint_List_1_IntPoint_PolyFillType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663565);
			Clipper.NativeMethodInfoPtr_SimplifyPolygons_Public_Static_List_1_List_1_IntPoint_List_1_List_1_IntPoint_PolyFillType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663566);
			Clipper.NativeMethodInfoPtr_DistanceSqrd_Private_Static_Double_IntPoint_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663567);
			Clipper.NativeMethodInfoPtr_DistanceFromLineSqrd_Private_Static_Double_IntPoint_IntPoint_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663568);
			Clipper.NativeMethodInfoPtr_SlopesNearCollinear_Private_Static_Boolean_IntPoint_IntPoint_IntPoint_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663569);
			Clipper.NativeMethodInfoPtr_PointsAreClose_Private_Static_Boolean_IntPoint_IntPoint_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663570);
			Clipper.NativeMethodInfoPtr_ExcludeOp_Private_Static_OutPt_OutPt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663571);
			Clipper.NativeMethodInfoPtr_CleanPolygon_Public_Static_List_1_IntPoint_List_1_IntPoint_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663572);
			Clipper.NativeMethodInfoPtr_CleanPolygons_Public_Static_List_1_List_1_IntPoint_List_1_List_1_IntPoint_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663573);
			Clipper.NativeMethodInfoPtr_Minkowski_Internal_Static_List_1_List_1_IntPoint_List_1_IntPoint_List_1_IntPoint_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663574);
			Clipper.NativeMethodInfoPtr_MinkowskiSum_Public_Static_List_1_List_1_IntPoint_List_1_IntPoint_List_1_IntPoint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663575);
			Clipper.NativeMethodInfoPtr_TranslatePath_Private_Static_List_1_IntPoint_List_1_IntPoint_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663576);
			Clipper.NativeMethodInfoPtr_MinkowskiSum_Public_Static_List_1_List_1_IntPoint_List_1_IntPoint_List_1_List_1_IntPoint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663577);
			Clipper.NativeMethodInfoPtr_MinkowskiDiff_Public_Static_List_1_List_1_IntPoint_List_1_IntPoint_List_1_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663578);
			Clipper.NativeMethodInfoPtr_PolyTreeToPaths_Public_Static_List_1_List_1_IntPoint_PolyTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663579);
			Clipper.NativeMethodInfoPtr_AddPolyNodeToPaths_Internal_Static_Void_PolyNode_NodeType_List_1_List_1_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663580);
			Clipper.NativeMethodInfoPtr_OpenPathsFromPolyTree_Public_Static_List_1_List_1_IntPoint_PolyTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663581);
			Clipper.NativeMethodInfoPtr_ClosedPathsFromPolyTree_Public_Static_List_1_List_1_IntPoint_PolyTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipper>.NativeClassPtr, 100663582);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0001B2A4 File Offset: 0x000194A4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 597557, RefRangeEnd = 597564, XrefRangeStart = 597512, XrefRangeEnd = 597557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Clipper(int InitOptions = 0)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Clipper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref InitOptions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0001B2EC File Offset: 0x000194EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 597564, XrefRangeEnd = 597573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertMaxima(long X)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref X;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_InsertMaxima_Private_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000198 RID: 408 RVA: 0x0001B32C File Offset: 0x0001952C
		// (set) Token: 0x06000199 RID: 409 RVA: 0x0001B368 File Offset: 0x00019568
		public unsafe int LastIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_get_LastIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_set_LastIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600019A RID: 410 RVA: 0x0001B3A8 File Offset: 0x000195A8
		// (set) Token: 0x0600019B RID: 411 RVA: 0x0001B3E4 File Offset: 0x000195E4
		public unsafe bool ReverseSolution
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_get_ReverseSolution_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_set_ReverseSolution_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600019C RID: 412 RVA: 0x0001B424 File Offset: 0x00019624
		// (set) Token: 0x0600019D RID: 413 RVA: 0x0001B460 File Offset: 0x00019660
		public unsafe bool StrictlySimple
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_get_StrictlySimple_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_set_StrictlySimple_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0001B4A0 File Offset: 0x000196A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 597573, XrefRangeEnd = 597574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Execute(ClipType clipType, List<List<IntPoint>> solution, PolyFillType FillType = PolyFillType.pftEvenOdd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clipType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(solution);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref FillType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_Execute_Public_Boolean_ClipType_List_1_List_1_IntPoint_PolyFillType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0001B50C File Offset: 0x0001970C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 597574, XrefRangeEnd = 597575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Execute(ClipType clipType, PolyTree polytree, PolyFillType FillType = PolyFillType.pftEvenOdd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clipType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(polytree);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref FillType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_Execute_Public_Boolean_ClipType_PolyTree_PolyFillType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0001B578 File Offset: 0x00019778
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 597582, RefRangeEnd = 597589, XrefRangeStart = 597575, XrefRangeEnd = 597582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Execute(ClipType clipType, List<List<IntPoint>> solution, PolyFillType subjFillType, PolyFillType clipFillType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clipType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(solution);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref subjFillType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clipFillType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_Execute_Public_Boolean_ClipType_List_1_List_1_IntPoint_PolyFillType_PolyFillType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0001B5F0 File Offset: 0x000197F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 597594, RefRangeEnd = 597596, XrefRangeStart = 597589, XrefRangeEnd = 597594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Execute(ClipType clipType, PolyTree polytree, PolyFillType subjFillType, PolyFillType clipFillType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clipType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(polytree);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref subjFillType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clipFillType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_Execute_Public_Boolean_ClipType_PolyTree_PolyFillType_PolyFillType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0001B668 File Offset: 0x00019868
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 597598, RefRangeEnd = 597599, XrefRangeStart = 597596, XrefRangeEnd = 597598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixHoleLinkage(OutRec outRec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outRec);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_FixHoleLinkage_Internal_Void_OutRec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0001B6AC File Offset: 0x000198AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 597649, RefRangeEnd = 597651, XrefRangeStart = 597599, XrefRangeEnd = 597649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ExecuteInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_ExecuteInternal_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0001B6E8 File Offset: 0x000198E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 597662, RefRangeEnd = 597666, XrefRangeStart = 597651, XrefRangeEnd = 597662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeAllPolyPts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_DisposeAllPolyPts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0001B71C File Offset: 0x0001991C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 597675, RefRangeEnd = 597682, XrefRangeStart = 597666, XrefRangeEnd = 597675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddJoin(OutPt Op1, OutPt Op2, IntPoint OffPt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Op1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(Op2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref OffPt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_AddJoin_Private_Void_OutPt_OutPt_IntPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0001B780 File Offset: 0x00019980
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 597690, RefRangeEnd = 597691, XrefRangeStart = 597682, XrefRangeEnd = 597690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddGhostJoin(OutPt Op, IntPoint OffPt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Op);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref OffPt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_AddGhostJoin_Private_Void_OutPt_IntPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0001B7D0 File Offset: 0x000199D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 597729, RefRangeEnd = 597731, XrefRangeStart = 597691, XrefRangeEnd = 597729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertLocalMinimaIntoAEL(long botY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref botY;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_InsertLocalMinimaIntoAEL_Private_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0001B810 File Offset: 0x00019A10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 597745, RefRangeEnd = 597748, XrefRangeStart = 597731, XrefRangeEnd = 597745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertEdgeIntoAEL(TEdge edge, TEdge startEdge)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(edge);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startEdge);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_InsertEdgeIntoAEL_Private_Void_TEdge_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0001B864 File Offset: 0x00019A64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 597748, RefRangeEnd = 597750, XrefRangeStart = 597748, XrefRangeEnd = 597748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool E2InsertsBeforeE1(TEdge e1, TEdge e2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_E2InsertsBeforeE1_Private_Boolean_TEdge_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0001B8C4 File Offset: 0x00019AC4
		[CallerCount(0)]
		public unsafe bool IsEvenOddFillType(TEdge edge)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(edge);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_IsEvenOddFillType_Private_Boolean_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0001B914 File Offset: 0x00019B14
		[CallerCount(0)]
		public unsafe bool IsEvenOddAltFillType(TEdge edge)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(edge);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_IsEvenOddAltFillType_Private_Boolean_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0001B964 File Offset: 0x00019B64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 597752, RefRangeEnd = 597755, XrefRangeStart = 597750, XrefRangeEnd = 597752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsContributing(TEdge edge)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(edge);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_IsContributing_Private_Boolean_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0001B9B4 File Offset: 0x00019BB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 597772, RefRangeEnd = 597775, XrefRangeStart = 597755, XrefRangeEnd = 597772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWindingCount(TEdge edge)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(edge);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_SetWindingCount_Private_Void_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0001B9F8 File Offset: 0x00019BF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 597783, RefRangeEnd = 597785, XrefRangeStart = 597775, XrefRangeEnd = 597783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddEdgeToSEL(TEdge edge)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(edge);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_AddEdgeToSEL_Private_Void_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0001BA3C File Offset: 0x00019C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 597785, XrefRangeEnd = 597790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PopEdgeFromSEL(out TEdge e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_PopEdgeFromSEL_Internal_Boolean_byref_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				e = ((intPtr4 == 0) ? null : new TEdge(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0001BA9C File Offset: 0x00019C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 597790, XrefRangeEnd = 597793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyAELToSEL()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_CopyAELToSEL_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0001BAD0 File Offset: 0x00019CD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 597814, RefRangeEnd = 597816, XrefRangeStart = 597793, XrefRangeEnd = 597814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwapPositionsInSEL(TEdge edge1, TEdge edge2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(edge1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(edge2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_SwapPositionsInSEL_Private_Void_TEdge_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0001BB24 File Offset: 0x00019D24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 597819, RefRangeEnd = 597820, XrefRangeStart = 597816, XrefRangeEnd = 597819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddLocalMaxPoly(TEdge e1, TEdge e2, IntPoint pt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_AddLocalMaxPoly_Private_Void_TEdge_TEdge_IntPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0001BB88 File Offset: 0x00019D88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 597831, RefRangeEnd = 597833, XrefRangeStart = 597820, XrefRangeEnd = 597831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutPt AddLocalMinPoly(TEdge e1, TEdge e2, IntPoint pt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_AddLocalMinPoly_Private_OutPt_TEdge_TEdge_IntPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OutPt>(intPtr3) : null;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0001BBF8 File Offset: 0x00019DF8
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 597837, RefRangeEnd = 597856, XrefRangeStart = 597833, XrefRangeEnd = 597837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutPt AddOutPt(TEdge e, IntPoint pt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_AddOutPt_Private_OutPt_TEdge_IntPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OutPt>(intPtr3) : null;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0001BC58 File Offset: 0x00019E58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 597859, RefRangeEnd = 597860, XrefRangeStart = 597856, XrefRangeEnd = 597859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutPt GetLastOutPt(TEdge e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_GetLastOutPt_Private_OutPt_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OutPt>(intPtr3) : null;
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0001BCA8 File Offset: 0x00019EA8
		[CallerCount(0)]
		public unsafe void SwapPoints(ref IntPoint pt1, ref IntPoint pt2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pt1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pt2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_SwapPoints_Internal_Void_byref_IntPoint_byref_IntPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0001BCF4 File Offset: 0x00019EF4
		[CallerCount(0)]
		public unsafe bool HorzSegmentsOverlap(long seg1a, long seg1b, long seg2a, long seg2b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref seg1a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seg1b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seg2a;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seg2b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_HorzSegmentsOverlap_Private_Boolean_Int64_Int64_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0001BD68 File Offset: 0x00019F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 597860, XrefRangeEnd = 597865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHoleState(TEdge e, OutRec outRec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outRec);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_SetHoleState_Private_Void_TEdge_OutRec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0001BDBC File Offset: 0x00019FBC
		[CallerCount(0)]
		public unsafe double GetDx(IntPoint pt1, IntPoint pt2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pt2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_GetDx_Private_Double_IntPoint_IntPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0001BE14 File Offset: 0x0001A014
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 597887, RefRangeEnd = 597893, XrefRangeStart = 597865, XrefRangeEnd = 597887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FirstIsBottomPt(OutPt btmPt1, OutPt btmPt2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(btmPt1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(btmPt2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_FirstIsBottomPt_Private_Boolean_OutPt_OutPt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0001BE74 File Offset: 0x0001A074
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 597897, RefRangeEnd = 597901, XrefRangeStart = 597893, XrefRangeEnd = 597897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutPt GetBottomPt(OutPt pp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_GetBottomPt_Private_OutPt_OutPt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OutPt>(intPtr3) : null;
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0001BEC4 File Offset: 0x0001A0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 597901, XrefRangeEnd = 597906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutRec GetLowermostRec(OutRec outRec1, OutRec outRec2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outRec1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outRec2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_GetLowermostRec_Private_OutRec_OutRec_OutRec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OutRec>(intPtr3) : null;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0001BF28 File Offset: 0x0001A128
		[CallerCount(0)]
		public unsafe bool OutRec1RightOfOutRec2(OutRec outRec1, OutRec outRec2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outRec1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outRec2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_OutRec1RightOfOutRec2_Private_Boolean_OutRec_OutRec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0001BF88 File Offset: 0x0001A188
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 597914, RefRangeEnd = 597916, XrefRangeStart = 597906, XrefRangeEnd = 597914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutRec GetOutRec(int idx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_GetOutRec_Private_OutRec_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OutRec>(intPtr3) : null;
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0001BFD4 File Offset: 0x0001A1D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 597982, RefRangeEnd = 597983, XrefRangeStart = 597916, XrefRangeEnd = 597982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendPolygon(TEdge e1, TEdge e2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_AppendPolygon_Private_Void_TEdge_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0001C028 File Offset: 0x0001A228
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 597985, RefRangeEnd = 597987, XrefRangeStart = 597983, XrefRangeEnd = 597985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReversePolyPtLinks(OutPt pp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_ReversePolyPtLinks_Private_Void_OutPt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0001C06C File Offset: 0x0001A26C
		[CallerCount(0)]
		public unsafe static void SwapSides(TEdge edge1, TEdge edge2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(edge1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(edge2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_SwapSides_Private_Static_Void_TEdge_TEdge_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0001C0B4 File Offset: 0x0001A2B4
		[CallerCount(0)]
		public unsafe static void SwapPolyIndexes(TEdge edge1, TEdge edge2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(edge1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(edge2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_SwapPolyIndexes_Private_Static_Void_TEdge_TEdge_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0001C0FC File Offset: 0x0001A2FC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 598018, RefRangeEnd = 598024, XrefRangeStart = 597987, XrefRangeEnd = 598018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IntersectEdges(TEdge e1, TEdge e2, IntPoint pt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_IntersectEdges_Private_Void_TEdge_TEdge_IntPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0001C160 File Offset: 0x0001A360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 598024, XrefRangeEnd = 598029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteFromSEL(TEdge e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_DeleteFromSEL_Private_Void_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0001C1A4 File Offset: 0x0001A3A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 598036, RefRangeEnd = 598038, XrefRangeStart = 598029, XrefRangeEnd = 598036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessHorizontals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_ProcessHorizontals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0001C1D8 File Offset: 0x0001A3D8
		[CallerCount(0)]
		public unsafe void GetHorzDirection(TEdge HorzEdge, out Direction Dir, out long Left, out long Right)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(HorzEdge);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &Dir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &Left;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &Right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_GetHorzDirection_Private_Void_TEdge_byref_Direction_byref_Int64_byref_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0001C248 File Offset: 0x0001A448
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 598086, RefRangeEnd = 598087, XrefRangeStart = 598038, XrefRangeEnd = 598086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessHorizontal(TEdge horzEdge)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(horzEdge);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_ProcessHorizontal_Private_Void_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0001C28C File Offset: 0x0001A48C
		[CallerCount(0)]
		public unsafe TEdge GetNextInAEL(TEdge e, Direction Direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_GetNextInAEL_Private_TEdge_TEdge_Direction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TEdge>(intPtr3) : null;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0001C2EC File Offset: 0x0001A4EC
		[CallerCount(0)]
		public unsafe bool IsMinima(TEdge e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_IsMinima_Private_Boolean_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0001C33C File Offset: 0x0001A53C
		[CallerCount(0)]
		public unsafe bool IsMaxima(TEdge e, double Y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_IsMaxima_Private_Boolean_TEdge_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0001C398 File Offset: 0x0001A598
		[CallerCount(0)]
		public unsafe bool IsIntermediate(TEdge e, double Y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_IsIntermediate_Private_Boolean_TEdge_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0001C3F4 File Offset: 0x0001A5F4
		[CallerCount(0)]
		public unsafe TEdge GetMaximaPair(TEdge e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_GetMaximaPair_Internal_TEdge_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TEdge>(intPtr3) : null;
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0001C444 File Offset: 0x0001A644
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 598087, RefRangeEnd = 598089, XrefRangeStart = 598087, XrefRangeEnd = 598087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TEdge GetMaximaPairEx(TEdge e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_GetMaximaPairEx_Internal_TEdge_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TEdge>(intPtr3) : null;
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0001C494 File Offset: 0x0001A694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 598103, RefRangeEnd = 598104, XrefRangeStart = 598089, XrefRangeEnd = 598103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ProcessIntersections(long topY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref topY;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_ProcessIntersections_Private_Boolean_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0001C4E0 File Offset: 0x0001A6E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 598127, RefRangeEnd = 598128, XrefRangeStart = 598104, XrefRangeEnd = 598127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildIntersectList(long topY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref topY;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_BuildIntersectList_Private_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0001C520 File Offset: 0x0001A720
		[CallerCount(0)]
		public unsafe bool EdgesAdjacent(IntersectNode inode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_EdgesAdjacent_Private_Boolean_IntersectNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0001C570 File Offset: 0x0001A770
		[CallerCount(0)]
		public unsafe static int IntersectNodeSort(IntersectNode node1, IntersectNode node2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_IntersectNodeSort_Private_Static_Int32_IntersectNode_IntersectNode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0001C5C4 File Offset: 0x0001A7C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 598154, RefRangeEnd = 598155, XrefRangeStart = 598128, XrefRangeEnd = 598154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FixupIntersectionOrder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_FixupIntersectionOrder_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0001C600 File Offset: 0x0001A800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 598155, XrefRangeEnd = 598164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessIntersectList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_ProcessIntersectList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0001C634 File Offset: 0x0001A834
		[CallerCount(0)]
		public unsafe static long Round(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_Round_Internal_Static_Int64_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0001C674 File Offset: 0x0001A874
		[CallerCount(0)]
		public unsafe static long TopX(TEdge edge, long currentY)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(edge);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_TopX_Private_Static_Int64_TEdge_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0001C6C4 File Offset: 0x0001A8C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 598192, RefRangeEnd = 598193, XrefRangeStart = 598164, XrefRangeEnd = 598192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IntersectPoint(TEdge edge1, TEdge edge2, out IntPoint ip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(edge1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(edge2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_IntersectPoint_Private_Void_TEdge_TEdge_byref_IntPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0001C728 File Offset: 0x0001A928
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 598231, RefRangeEnd = 598232, XrefRangeStart = 598193, XrefRangeEnd = 598231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessEdgesAtTopOfScanbeam(long topY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref topY;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_ProcessEdgesAtTopOfScanbeam_Private_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0001C768 File Offset: 0x0001A968
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 598245, RefRangeEnd = 598246, XrefRangeStart = 598232, XrefRangeEnd = 598245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoMaxima(TEdge e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_DoMaxima_Private_Void_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0001C7AC File Offset: 0x0001A9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 598246, XrefRangeEnd = 598263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReversePaths(List<List<IntPoint>> polys)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(polys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_ReversePaths_Public_Static_Void_List_1_List_1_IntPoint_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0001C7E4 File Offset: 0x0001A9E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 598273, RefRangeEnd = 598277, XrefRangeStart = 598263, XrefRangeEnd = 598273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Orientation(List<IntPoint> poly)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(poly);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_Orientation_Public_Static_Boolean_List_1_IntPoint_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0001C828 File Offset: 0x0001AA28
		[CallerCount(0)]
		public unsafe int PointCount(OutPt pts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_PointCount_Private_Int32_OutPt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0001C878 File Offset: 0x0001AA78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 598299, RefRangeEnd = 598300, XrefRangeStart = 598277, XrefRangeEnd = 598299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildResult(List<List<IntPoint>> polyg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(polyg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_BuildResult_Private_Void_List_1_List_1_IntPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0001C8BC File Offset: 0x0001AABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 598339, RefRangeEnd = 598340, XrefRangeStart = 598300, XrefRangeEnd = 598339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildResult2(PolyTree polytree)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(polytree);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_BuildResult2_Private_Void_PolyTree_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0001C900 File Offset: 0x0001AB00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 598343, RefRangeEnd = 598344, XrefRangeStart = 598340, XrefRangeEnd = 598343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixupOutPolyline(OutRec outrec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outrec);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_FixupOutPolyline_Private_Void_OutRec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0001C944 File Offset: 0x0001AB44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 598354, RefRangeEnd = 598355, XrefRangeStart = 598344, XrefRangeEnd = 598354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixupOutPolygon(OutRec outRec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outRec);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_FixupOutPolygon_Private_Void_OutRec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0001C988 File Offset: 0x0001AB88
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 598367, RefRangeEnd = 598373, XrefRangeStart = 598355, XrefRangeEnd = 598367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutPt DupOutPt(OutPt outPt, bool InsertAfter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outPt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref InsertAfter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_DupOutPt_Private_OutPt_OutPt_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OutPt>(intPtr3) : null;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0001C9E8 File Offset: 0x0001ABE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 598373, XrefRangeEnd = 598384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetOverlap(long a1, long a2, long b1, long b2, out long Left, out long Right)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &Left;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &Right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_GetOverlap_Private_Boolean_Int64_Int64_Int64_Int64_byref_Int64_byref_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0001CA7C File Offset: 0x0001AC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 598384, XrefRangeEnd = 598404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool JoinHorz(OutPt op1, OutPt op1b, OutPt op2, OutPt op2b, IntPoint Pt, bool DiscardLeft)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(op1b);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(op2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(op2b);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Pt;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref DiscardLeft;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_JoinHorz_Private_Boolean_OutPt_OutPt_OutPt_OutPt_IntPoint_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0001CB1C File Offset: 0x0001AD1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 598446, RefRangeEnd = 598447, XrefRangeStart = 598404, XrefRangeEnd = 598446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool JoinPoints(Join j, OutRec outRec1, OutRec outRec2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(j);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outRec1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outRec2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_JoinPoints_Private_Boolean_Join_OutRec_OutRec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0001CB90 File Offset: 0x0001AD90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 598447, XrefRangeEnd = 598455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PointInPolygon(IntPoint pt, List<IntPoint> path)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_PointInPolygon_Public_Static_Int32_IntPoint_List_1_IntPoint_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0001CBE0 File Offset: 0x0001ADE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 598455, XrefRangeEnd = 598456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PointInPolygon(IntPoint pt, OutPt op)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(op);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_PointInPolygon_Private_Static_Int32_IntPoint_OutPt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0001CC30 File Offset: 0x0001AE30
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 598457, RefRangeEnd = 598464, XrefRangeStart = 598456, XrefRangeEnd = 598457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Poly2ContainsPoly1(OutPt outPt1, OutPt outPt2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outPt1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outPt2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_Poly2ContainsPoly1_Private_Static_Boolean_OutPt_OutPt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0001CC84 File Offset: 0x0001AE84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 598480, RefRangeEnd = 598482, XrefRangeStart = 598464, XrefRangeEnd = 598480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixupFirstLefts1(OutRec OldOutRec, OutRec NewOutRec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(OldOutRec);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(NewOutRec);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_FixupFirstLefts1_Private_Void_OutRec_OutRec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0001CCD8 File Offset: 0x0001AED8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 598503, RefRangeEnd = 598506, XrefRangeStart = 598482, XrefRangeEnd = 598503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixupFirstLefts2(OutRec innerOutRec, OutRec outerOutRec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerOutRec);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outerOutRec);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_FixupFirstLefts2_Private_Void_OutRec_OutRec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0001CD2C File Offset: 0x0001AF2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 598521, RefRangeEnd = 598522, XrefRangeStart = 598506, XrefRangeEnd = 598521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixupFirstLefts3(OutRec OldOutRec, OutRec NewOutRec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(OldOutRec);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(NewOutRec);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_FixupFirstLefts3_Private_Void_OutRec_OutRec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0001CD80 File Offset: 0x0001AF80
		[CallerCount(0)]
		public unsafe static OutRec ParseFirstLeft(OutRec FirstLeft)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(FirstLeft);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_ParseFirstLeft_Private_Static_OutRec_OutRec_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OutRec>(intPtr3) : null;
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0001CDC4 File Offset: 0x0001AFC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 598583, RefRangeEnd = 598584, XrefRangeStart = 598522, XrefRangeEnd = 598583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void JoinCommonEdges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_JoinCommonEdges_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0001CDF8 File Offset: 0x0001AFF8
		[CallerCount(0)]
		public unsafe void UpdateOutPtIdxs(OutRec outrec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outrec);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_UpdateOutPtIdxs_Private_Void_OutRec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0001CE3C File Offset: 0x0001B03C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 598607, RefRangeEnd = 598608, XrefRangeStart = 598584, XrefRangeEnd = 598607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoSimplePolygons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_DoSimplePolygons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0001CE70 File Offset: 0x0001B070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 598608, XrefRangeEnd = 598618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Area(List<IntPoint> poly)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(poly);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_Area_Public_Static_Double_List_1_IntPoint_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0001CEB4 File Offset: 0x0001B0B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 598618, RefRangeEnd = 598620, XrefRangeStart = 598618, XrefRangeEnd = 598618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double Area(OutRec outRec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outRec);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_Area_Internal_Double_OutRec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0001CF04 File Offset: 0x0001B104
		[CallerCount(0)]
		public unsafe double Area(OutPt op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_Area_Internal_Double_OutPt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0001CF54 File Offset: 0x0001B154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 598620, XrefRangeEnd = 598632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<List<IntPoint>> SimplifyPolygon(List<IntPoint> poly, PolyFillType fillType = PolyFillType.pftEvenOdd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(poly);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fillType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_SimplifyPolygon_Public_Static_List_1_List_1_IntPoint_List_1_IntPoint_PolyFillType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<List<IntPoint>>>(intPtr3) : null;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0001CFA8 File Offset: 0x0001B1A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 598632, XrefRangeEnd = 598644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<List<IntPoint>> SimplifyPolygons(List<List<IntPoint>> polys, PolyFillType fillType = PolyFillType.pftEvenOdd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(polys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fillType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_SimplifyPolygons_Public_Static_List_1_List_1_IntPoint_List_1_List_1_IntPoint_PolyFillType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<List<IntPoint>>>(intPtr3) : null;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0001CFFC File Offset: 0x0001B1FC
		[CallerCount(0)]
		public unsafe static double DistanceSqrd(IntPoint pt1, IntPoint pt2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pt2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_DistanceSqrd_Private_Static_Double_IntPoint_IntPoint_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0001D048 File Offset: 0x0001B248
		[CallerCount(0)]
		public unsafe static double DistanceFromLineSqrd(IntPoint pt, IntPoint ln1, IntPoint ln2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ln1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ln2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_DistanceFromLineSqrd_Private_Static_Double_IntPoint_IntPoint_IntPoint_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0001D0A4 File Offset: 0x0001B2A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 598651, RefRangeEnd = 598652, XrefRangeStart = 598644, XrefRangeEnd = 598651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SlopesNearCollinear(IntPoint pt1, IntPoint pt2, IntPoint pt3, double distSqrd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pt2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pt3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distSqrd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_SlopesNearCollinear_Private_Static_Boolean_IntPoint_IntPoint_IntPoint_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0001D10C File Offset: 0x0001B30C
		[CallerCount(0)]
		public unsafe static bool PointsAreClose(IntPoint pt1, IntPoint pt2, double distSqrd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pt2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distSqrd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_PointsAreClose_Private_Static_Boolean_IntPoint_IntPoint_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0001D168 File Offset: 0x0001B368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 598652, XrefRangeEnd = 598654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static OutPt ExcludeOp(OutPt op)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_ExcludeOp_Private_Static_OutPt_OutPt_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OutPt>(intPtr3) : null;
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0001D1AC File Offset: 0x0001B3AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 598695, RefRangeEnd = 598696, XrefRangeStart = 598654, XrefRangeEnd = 598695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<IntPoint> CleanPolygon(List<IntPoint> path, double distance = 1.415)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_CleanPolygon_Public_Static_List_1_IntPoint_List_1_IntPoint_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IntPoint>>(intPtr3) : null;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0001D200 File Offset: 0x0001B400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 598696, XrefRangeEnd = 598713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<List<IntPoint>> CleanPolygons(List<List<IntPoint>> polys, double distance = 1.415)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(polys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_CleanPolygons_Public_Static_List_1_List_1_IntPoint_List_1_List_1_IntPoint_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<List<IntPoint>>>(intPtr3) : null;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0001D254 File Offset: 0x0001B454
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 598814, RefRangeEnd = 598817, XrefRangeStart = 598713, XrefRangeEnd = 598814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<List<IntPoint>> Minkowski(List<IntPoint> pattern, List<IntPoint> path, bool IsSum, bool IsClosed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref IsSum;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref IsClosed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_Minkowski_Internal_Static_List_1_List_1_IntPoint_List_1_IntPoint_List_1_IntPoint_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<List<IntPoint>>>(intPtr3) : null;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0001D2C8 File Offset: 0x0001B4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 598817, XrefRangeEnd = 598824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<List<IntPoint>> MinkowskiSum(List<IntPoint> pattern, List<IntPoint> path, bool pathIsClosed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathIsClosed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_MinkowskiSum_Public_Static_List_1_List_1_IntPoint_List_1_IntPoint_List_1_IntPoint_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<List<IntPoint>>>(intPtr3) : null;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0001D32C File Offset: 0x0001B52C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 598841, RefRangeEnd = 598842, XrefRangeStart = 598824, XrefRangeEnd = 598841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<IntPoint> TranslatePath(List<IntPoint> path, IntPoint delta)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_TranslatePath_Private_Static_List_1_IntPoint_List_1_IntPoint_IntPoint_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IntPoint>>(intPtr3) : null;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0001D380 File Offset: 0x0001B580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 598842, XrefRangeEnd = 598872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<List<IntPoint>> MinkowskiSum(List<IntPoint> pattern, List<List<IntPoint>> paths, bool pathIsClosed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paths);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathIsClosed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_MinkowskiSum_Public_Static_List_1_List_1_IntPoint_List_1_IntPoint_List_1_List_1_IntPoint_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<List<IntPoint>>>(intPtr3) : null;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0001D3E4 File Offset: 0x0001B5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 598872, XrefRangeEnd = 598879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<List<IntPoint>> MinkowskiDiff(List<IntPoint> poly1, List<IntPoint> poly2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(poly1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(poly2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_MinkowskiDiff_Public_Static_List_1_List_1_IntPoint_List_1_IntPoint_List_1_IntPoint_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<List<IntPoint>>>(intPtr3) : null;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0001D43C File Offset: 0x0001B63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 598879, XrefRangeEnd = 598890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<List<IntPoint>> PolyTreeToPaths(PolyTree polytree)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(polytree);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_PolyTreeToPaths_Public_Static_List_1_List_1_IntPoint_PolyTree_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<List<IntPoint>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0001D480 File Offset: 0x0001B680
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 598910, RefRangeEnd = 598913, XrefRangeStart = 598890, XrefRangeEnd = 598910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddPolyNodeToPaths(PolyNode polynode, Clipper.NodeType nt, List<List<IntPoint>> paths)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(polynode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paths);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_AddPolyNodeToPaths_Internal_Static_Void_PolyNode_NodeType_List_1_List_1_IntPoint_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0001D4D8 File Offset: 0x0001B6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 598913, XrefRangeEnd = 598933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<List<IntPoint>> OpenPathsFromPolyTree(PolyTree polytree)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(polytree);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_OpenPathsFromPolyTree_Public_Static_List_1_List_1_IntPoint_PolyTree_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<List<IntPoint>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0001D51C File Offset: 0x0001B71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 598933, XrefRangeEnd = 598944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<List<IntPoint>> ClosedPathsFromPolyTree(PolyTree polytree)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(polytree);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipper.NativeMethodInfoPtr_ClosedPathsFromPolyTree_Public_Static_List_1_List_1_IntPoint_PolyTree_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<List<IntPoint>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002C7A File Offset: 0x00000E7A
		public Clipper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0001D560 File Offset: 0x0001B760
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00002C83 File Offset: 0x00000E83
		public unsafe static int ioReverseSolution
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Clipper.NativeFieldInfoPtr_ioReverseSolution, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Clipper.NativeFieldInfoPtr_ioReverseSolution, (void*)(&value));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000206 RID: 518 RVA: 0x0001D57C File Offset: 0x0001B77C
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00002C91 File Offset: 0x00000E91
		public unsafe static int ioStrictlySimple
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Clipper.NativeFieldInfoPtr_ioStrictlySimple, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Clipper.NativeFieldInfoPtr_ioStrictlySimple, (void*)(&value));
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000208 RID: 520 RVA: 0x0001D598 File Offset: 0x0001B798
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00002C9F File Offset: 0x00000E9F
		public unsafe static int ioPreserveCollinear
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Clipper.NativeFieldInfoPtr_ioPreserveCollinear, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Clipper.NativeFieldInfoPtr_ioPreserveCollinear, (void*)(&value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600020A RID: 522 RVA: 0x0001D5B4 File Offset: 0x0001B7B4
		// (set) Token: 0x0600020B RID: 523 RVA: 0x00002CAD File Offset: 0x00000EAD
		public unsafe ClipType m_ClipType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr_m_ClipType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr_m_ClipType)) = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600020C RID: 524 RVA: 0x0001D5DC File Offset: 0x0001B7DC
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00002CC8 File Offset: 0x00000EC8
		public unsafe Maxima m_Maxima
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr_m_Maxima);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Maxima>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr_m_Maxima), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600020E RID: 526 RVA: 0x0001D60C File Offset: 0x0001B80C
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00002CE7 File Offset: 0x00000EE7
		public unsafe TEdge m_SortedEdges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr_m_SortedEdges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TEdge>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr_m_SortedEdges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000210 RID: 528 RVA: 0x0001D63C File Offset: 0x0001B83C
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00002D06 File Offset: 0x00000F06
		public unsafe List<IntersectNode> m_IntersectList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr_m_IntersectList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IntersectNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr_m_IntersectList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000212 RID: 530 RVA: 0x0001D66C File Offset: 0x0001B86C
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00002D25 File Offset: 0x00000F25
		public unsafe IComparer<IntersectNode> m_IntersectNodeComparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr_m_IntersectNodeComparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer<IntersectNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr_m_IntersectNodeComparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000214 RID: 532 RVA: 0x0001D69C File Offset: 0x0001B89C
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00002D44 File Offset: 0x00000F44
		public unsafe bool m_ExecuteLocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr_m_ExecuteLocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr_m_ExecuteLocked)) = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000216 RID: 534 RVA: 0x0001D6C4 File Offset: 0x0001B8C4
		// (set) Token: 0x06000217 RID: 535 RVA: 0x00002D5F File Offset: 0x00000F5F
		public unsafe PolyFillType m_ClipFillType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr_m_ClipFillType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr_m_ClipFillType)) = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000218 RID: 536 RVA: 0x0001D6EC File Offset: 0x0001B8EC
		// (set) Token: 0x06000219 RID: 537 RVA: 0x00002D7A File Offset: 0x00000F7A
		public unsafe PolyFillType m_SubjFillType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr_m_SubjFillType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr_m_SubjFillType)) = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600021A RID: 538 RVA: 0x0001D714 File Offset: 0x0001B914
		// (set) Token: 0x0600021B RID: 539 RVA: 0x00002D95 File Offset: 0x00000F95
		public unsafe List<Join> m_Joins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr_m_Joins);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Join>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr_m_Joins), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600021C RID: 540 RVA: 0x0001D744 File Offset: 0x0001B944
		// (set) Token: 0x0600021D RID: 541 RVA: 0x00002DB4 File Offset: 0x00000FB4
		public unsafe List<Join> m_GhostJoins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr_m_GhostJoins);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Join>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr_m_GhostJoins), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600021E RID: 542 RVA: 0x0001D774 File Offset: 0x0001B974
		// (set) Token: 0x0600021F RID: 543 RVA: 0x00002DD3 File Offset: 0x00000FD3
		public unsafe bool m_UsingPolyTree
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr_m_UsingPolyTree);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr_m_UsingPolyTree)) = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000220 RID: 544 RVA: 0x0001D79C File Offset: 0x0001B99C
		// (set) Token: 0x06000221 RID: 545 RVA: 0x00002DEE File Offset: 0x00000FEE
		public unsafe int _LastIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr__LastIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr__LastIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0001D7C4 File Offset: 0x0001B9C4
		// (set) Token: 0x06000223 RID: 547 RVA: 0x00002E09 File Offset: 0x00001009
		public unsafe bool _ReverseSolution_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr__ReverseSolution_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr__ReverseSolution_k__BackingField)) = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0001D7EC File Offset: 0x0001B9EC
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00002E24 File Offset: 0x00001024
		public unsafe bool _StrictlySimple_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr__StrictlySimple_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clipper.NativeFieldInfoPtr__StrictlySimple_k__BackingField)) = value;
			}
		}

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeFieldInfoPtr_ioReverseSolution;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeFieldInfoPtr_ioStrictlySimple;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeFieldInfoPtr_ioPreserveCollinear;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeFieldInfoPtr_m_ClipType;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeFieldInfoPtr_m_Maxima;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeFieldInfoPtr_m_SortedEdges;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeFieldInfoPtr_m_IntersectList;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeFieldInfoPtr_m_IntersectNodeComparer;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeFieldInfoPtr_m_ExecuteLocked;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeFieldInfoPtr_m_ClipFillType;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeFieldInfoPtr_m_SubjFillType;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeFieldInfoPtr_m_Joins;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeFieldInfoPtr_m_GhostJoins;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeFieldInfoPtr_m_UsingPolyTree;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeFieldInfoPtr__LastIndex_k__BackingField;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeFieldInfoPtr__ReverseSolution_k__BackingField;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeFieldInfoPtr__StrictlySimple_k__BackingField;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_InsertMaxima_Private_Void_Int64_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_get_LastIndex_Public_get_Int32_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_set_LastIndex_Public_set_Void_Int32_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_get_ReverseSolution_Public_get_Boolean_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_set_ReverseSolution_Public_set_Void_Boolean_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_get_StrictlySimple_Public_get_Boolean_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_set_StrictlySimple_Public_set_Void_Boolean_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Boolean_ClipType_List_1_List_1_IntPoint_PolyFillType_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Boolean_ClipType_PolyTree_PolyFillType_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Boolean_ClipType_List_1_List_1_IntPoint_PolyFillType_PolyFillType_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Boolean_ClipType_PolyTree_PolyFillType_PolyFillType_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_FixHoleLinkage_Internal_Void_OutRec_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteInternal_Private_Boolean_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_DisposeAllPolyPts_Private_Void_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_AddJoin_Private_Void_OutPt_OutPt_IntPoint_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_AddGhostJoin_Private_Void_OutPt_IntPoint_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_InsertLocalMinimaIntoAEL_Private_Void_Int64_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_InsertEdgeIntoAEL_Private_Void_TEdge_TEdge_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_E2InsertsBeforeE1_Private_Boolean_TEdge_TEdge_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_IsEvenOddFillType_Private_Boolean_TEdge_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_IsEvenOddAltFillType_Private_Boolean_TEdge_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_IsContributing_Private_Boolean_TEdge_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_SetWindingCount_Private_Void_TEdge_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_AddEdgeToSEL_Private_Void_TEdge_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_PopEdgeFromSEL_Internal_Boolean_byref_TEdge_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_CopyAELToSEL_Private_Void_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_SwapPositionsInSEL_Private_Void_TEdge_TEdge_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_AddLocalMaxPoly_Private_Void_TEdge_TEdge_IntPoint_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_AddLocalMinPoly_Private_OutPt_TEdge_TEdge_IntPoint_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_AddOutPt_Private_OutPt_TEdge_IntPoint_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_GetLastOutPt_Private_OutPt_TEdge_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_SwapPoints_Internal_Void_byref_IntPoint_byref_IntPoint_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_HorzSegmentsOverlap_Private_Boolean_Int64_Int64_Int64_Int64_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_SetHoleState_Private_Void_TEdge_OutRec_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_GetDx_Private_Double_IntPoint_IntPoint_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_FirstIsBottomPt_Private_Boolean_OutPt_OutPt_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_GetBottomPt_Private_OutPt_OutPt_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_GetLowermostRec_Private_OutRec_OutRec_OutRec_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_OutRec1RightOfOutRec2_Private_Boolean_OutRec_OutRec_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_GetOutRec_Private_OutRec_Int32_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_AppendPolygon_Private_Void_TEdge_TEdge_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_ReversePolyPtLinks_Private_Void_OutPt_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_SwapSides_Private_Static_Void_TEdge_TEdge_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_SwapPolyIndexes_Private_Static_Void_TEdge_TEdge_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_IntersectEdges_Private_Void_TEdge_TEdge_IntPoint_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_DeleteFromSEL_Private_Void_TEdge_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_ProcessHorizontals_Private_Void_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_GetHorzDirection_Private_Void_TEdge_byref_Direction_byref_Int64_byref_Int64_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_ProcessHorizontal_Private_Void_TEdge_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_GetNextInAEL_Private_TEdge_TEdge_Direction_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_IsMinima_Private_Boolean_TEdge_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_IsMaxima_Private_Boolean_TEdge_Double_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_IsIntermediate_Private_Boolean_TEdge_Double_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_GetMaximaPair_Internal_TEdge_TEdge_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_GetMaximaPairEx_Internal_TEdge_TEdge_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_ProcessIntersections_Private_Boolean_Int64_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_BuildIntersectList_Private_Void_Int64_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_EdgesAdjacent_Private_Boolean_IntersectNode_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_IntersectNodeSort_Private_Static_Int32_IntersectNode_IntersectNode_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_FixupIntersectionOrder_Private_Boolean_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_ProcessIntersectList_Private_Void_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_Round_Internal_Static_Int64_Double_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_TopX_Private_Static_Int64_TEdge_Int64_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_IntersectPoint_Private_Void_TEdge_TEdge_byref_IntPoint_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEdgesAtTopOfScanbeam_Private_Void_Int64_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_DoMaxima_Private_Void_TEdge_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_ReversePaths_Public_Static_Void_List_1_List_1_IntPoint_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_Orientation_Public_Static_Boolean_List_1_IntPoint_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_PointCount_Private_Int32_OutPt_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_BuildResult_Private_Void_List_1_List_1_IntPoint_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_BuildResult2_Private_Void_PolyTree_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_FixupOutPolyline_Private_Void_OutRec_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_FixupOutPolygon_Private_Void_OutRec_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_DupOutPt_Private_OutPt_OutPt_Boolean_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_GetOverlap_Private_Boolean_Int64_Int64_Int64_Int64_byref_Int64_byref_Int64_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_JoinHorz_Private_Boolean_OutPt_OutPt_OutPt_OutPt_IntPoint_Boolean_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_JoinPoints_Private_Boolean_Join_OutRec_OutRec_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_PointInPolygon_Public_Static_Int32_IntPoint_List_1_IntPoint_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_PointInPolygon_Private_Static_Int32_IntPoint_OutPt_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_Poly2ContainsPoly1_Private_Static_Boolean_OutPt_OutPt_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_FixupFirstLefts1_Private_Void_OutRec_OutRec_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_FixupFirstLefts2_Private_Void_OutRec_OutRec_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_FixupFirstLefts3_Private_Void_OutRec_OutRec_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr_ParseFirstLeft_Private_Static_OutRec_OutRec_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_JoinCommonEdges_Private_Void_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOutPtIdxs_Private_Void_OutRec_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_DoSimplePolygons_Private_Void_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_Area_Public_Static_Double_List_1_IntPoint_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_Area_Internal_Double_OutRec_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_Area_Internal_Double_OutPt_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_SimplifyPolygon_Public_Static_List_1_List_1_IntPoint_List_1_IntPoint_PolyFillType_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_SimplifyPolygons_Public_Static_List_1_List_1_IntPoint_List_1_List_1_IntPoint_PolyFillType_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_DistanceSqrd_Private_Static_Double_IntPoint_IntPoint_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_DistanceFromLineSqrd_Private_Static_Double_IntPoint_IntPoint_IntPoint_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_SlopesNearCollinear_Private_Static_Boolean_IntPoint_IntPoint_IntPoint_Double_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_PointsAreClose_Private_Static_Boolean_IntPoint_IntPoint_Double_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_ExcludeOp_Private_Static_OutPt_OutPt_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_CleanPolygon_Public_Static_List_1_IntPoint_List_1_IntPoint_Double_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr_CleanPolygons_Public_Static_List_1_List_1_IntPoint_List_1_List_1_IntPoint_Double_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_Minkowski_Internal_Static_List_1_List_1_IntPoint_List_1_IntPoint_List_1_IntPoint_Boolean_Boolean_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_MinkowskiSum_Public_Static_List_1_List_1_IntPoint_List_1_IntPoint_List_1_IntPoint_Boolean_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_TranslatePath_Private_Static_List_1_IntPoint_List_1_IntPoint_IntPoint_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_MinkowskiSum_Public_Static_List_1_List_1_IntPoint_List_1_IntPoint_List_1_List_1_IntPoint_Boolean_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr_MinkowskiDiff_Public_Static_List_1_List_1_IntPoint_List_1_IntPoint_List_1_IntPoint_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_PolyTreeToPaths_Public_Static_List_1_List_1_IntPoint_PolyTree_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_AddPolyNodeToPaths_Internal_Static_Void_PolyNode_NodeType_List_1_List_1_IntPoint_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_OpenPathsFromPolyTree_Public_Static_List_1_List_1_IntPoint_PolyTree_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_ClosedPathsFromPolyTree_Public_Static_List_1_List_1_IntPoint_PolyTree_0;

		// Token: 0x0200014F RID: 335
		public enum NodeType
		{
			// Token: 0x040013CF RID: 5071
			ntAny,
			// Token: 0x040013D0 RID: 5072
			ntOpen,
			// Token: 0x040013D1 RID: 5073
			ntClosed
		}
	}
}
