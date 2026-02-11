using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000070 RID: 112
	public static class Utility : global::Il2CppSystem.Object
	{
		// Token: 0x06000A43 RID: 2627 RVA: 0x0002C900 File Offset: 0x0002AB00
		// Note: this type is marked as 'beforefieldinit'.
		static Utility()
		{
			Il2CppClassPointerStore<Utility>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "Utility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Utility>.NativeClassPtr);
			Utility.NativeFieldInfoPtr_Epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility>.NativeClassPtr, "Epsilon");
			Utility.NativeFieldInfoPtr_circleVertexList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility>.NativeClassPtr, "circleVertexList");
			Utility.NativeMethodInfoPtr_DrawCircleGizmo_Public_Static_Void_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664685);
			Utility.NativeMethodInfoPtr_DrawCircleGizmo_Public_Static_Void_Vector2_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664686);
			Utility.NativeMethodInfoPtr_DrawOvalGizmo_Public_Static_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664687);
			Utility.NativeMethodInfoPtr_DrawOvalGizmo_Public_Static_Void_Vector2_Vector2_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664688);
			Utility.NativeMethodInfoPtr_DrawRectGizmo_Public_Static_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664689);
			Utility.NativeMethodInfoPtr_DrawRectGizmo_Public_Static_Void_Rect_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664690);
			Utility.NativeMethodInfoPtr_DrawRectGizmo_Public_Static_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664691);
			Utility.NativeMethodInfoPtr_DrawRectGizmo_Public_Static_Void_Vector2_Vector2_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664692);
			Utility.NativeMethodInfoPtr_GameObjectIsCulledOnCurrentCamera_Public_Static_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664693);
			Utility.NativeMethodInfoPtr_MoveColorTowards_Public_Static_Color_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664694);
			Utility.NativeMethodInfoPtr_ApplyDeadZone_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664695);
			Utility.NativeMethodInfoPtr_ApplySmoothing_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664696);
			Utility.NativeMethodInfoPtr_ApplySnapping_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664697);
			Utility.NativeMethodInfoPtr_TargetIsButton_Internal_Static_Boolean_InputControlType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664698);
			Utility.NativeMethodInfoPtr_TargetIsStandard_Internal_Static_Boolean_InputControlType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664699);
			Utility.NativeMethodInfoPtr_TargetIsAlias_Internal_Static_Boolean_InputControlType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664700);
			Utility.NativeMethodInfoPtr_ReadFromFile_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664701);
			Utility.NativeMethodInfoPtr_WriteToFile_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664702);
			Utility.NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664703);
			Utility.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664704);
			Utility.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664705);
			Utility.NativeMethodInfoPtr_IsNotZero_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664706);
			Utility.NativeMethodInfoPtr_IsZero_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664707);
			Utility.NativeMethodInfoPtr_Sign_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664708);
			Utility.NativeMethodInfoPtr_AbsoluteIsOverThreshold_Public_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664709);
			Utility.NativeMethodInfoPtr_NormalizeAngle_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664710);
			Utility.NativeMethodInfoPtr_VectorToAngle_Public_Static_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664711);
			Utility.NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664712);
			Utility.NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664713);
			Utility.NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664714);
			Utility.NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664715);
			Utility.NativeMethodInfoPtr_ValueFromSides_Internal_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664716);
			Utility.NativeMethodInfoPtr_ValueFromSides_Internal_Static_Single_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664717);
			Utility.NativeMethodInfoPtr_ArrayResize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664718);
			Utility.NativeMethodInfoPtr_ArrayExpand_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664719);
			Utility.NativeMethodInfoPtr_ArrayAppend_Public_Static_Void_byref_Il2CppArrayBase_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664720);
			Utility.NativeMethodInfoPtr_ArrayAppend_Public_Static_Void_byref_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664721);
			Utility.NativeMethodInfoPtr_NextPowerOfTwo_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664722);
			Utility.NativeMethodInfoPtr_get_Is32Bit_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664723);
			Utility.NativeMethodInfoPtr_get_Is64Bit_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664724);
			Utility.NativeMethodInfoPtr_GetPlatformName_Public_Static_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664725);
			Utility.NativeMethodInfoPtr_GetHumanUnderstandableWindowsVersion_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664726);
			Utility.NativeMethodInfoPtr_GetWindowsVersion_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664727);
			Utility.NativeMethodInfoPtr_GetSystemBuildNumber_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664728);
			Utility.NativeMethodInfoPtr_LoadScene_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664729);
			Utility.NativeMethodInfoPtr_PluginFileExtension_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100664730);
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x0002CCF0 File Offset: 0x0002AEF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790756, XrefRangeEnd = 790765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawCircleGizmo(Vector2 center, float radius)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_DrawCircleGizmo_Public_Static_Void_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0002CD30 File Offset: 0x0002AF30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 790779, RefRangeEnd = 790780, XrefRangeStart = 790765, XrefRangeEnd = 790779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawCircleGizmo(Vector2 center, float radius, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_DrawCircleGizmo_Public_Static_Void_Vector2_Single_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x0002CD80 File Offset: 0x0002AF80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 790789, RefRangeEnd = 790790, XrefRangeStart = 790780, XrefRangeEnd = 790789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawOvalGizmo(Vector2 center, Vector2 size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_DrawOvalGizmo_Public_Static_Void_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x0002CDC0 File Offset: 0x0002AFC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 790795, RefRangeEnd = 790796, XrefRangeStart = 790790, XrefRangeEnd = 790795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawOvalGizmo(Vector2 center, Vector2 size, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_DrawOvalGizmo_Public_Static_Void_Vector2_Vector2_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0002CE10 File Offset: 0x0002B010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790796, XrefRangeEnd = 790800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawRectGizmo(Rect rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_DrawRectGizmo_Public_Static_Void_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x0002CE44 File Offset: 0x0002B044
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 790808, RefRangeEnd = 790811, XrefRangeStart = 790800, XrefRangeEnd = 790808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawRectGizmo(Rect rect, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_DrawRectGizmo_Public_Static_Void_Rect_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x0002CE84 File Offset: 0x0002B084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790811, XrefRangeEnd = 790815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawRectGizmo(Vector2 center, Vector2 size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_DrawRectGizmo_Public_Static_Void_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x0002CEC4 File Offset: 0x0002B0C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 790823, RefRangeEnd = 790824, XrefRangeStart = 790815, XrefRangeEnd = 790823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawRectGizmo(Vector2 center, Vector2 size, Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_DrawRectGizmo_Public_Static_Void_Vector2_Vector2_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x0002CF14 File Offset: 0x0002B114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 790827, RefRangeEnd = 790828, XrefRangeStart = 790824, XrefRangeEnd = 790827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GameObjectIsCulledOnCurrentCamera(GameObject gameObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_GameObjectIsCulledOnCurrentCamera_Public_Static_Boolean_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x0002CF58 File Offset: 0x0002B158
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 790832, RefRangeEnd = 790833, XrefRangeStart = 790828, XrefRangeEnd = 790832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color MoveColorTowards(Color color0, Color color1, float maxDelta)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDelta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_MoveColorTowards_Public_Static_Color_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0002CFB4 File Offset: 0x0002B1B4
		[CallerCount(0)]
		public unsafe static float ApplyDeadZone(float value, float lowerDeadZone, float upperDeadZone)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowerDeadZone;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref upperDeadZone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_ApplyDeadZone_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x0002D010 File Offset: 0x0002B210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790833, XrefRangeEnd = 790842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ApplySmoothing(float thisValue, float lastValue, float deltaTime, float sensitivity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lastValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sensitivity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_ApplySmoothing_Public_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x0002D078 File Offset: 0x0002B278
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 790842, RefRangeEnd = 790844, XrefRangeStart = 790842, XrefRangeEnd = 790842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ApplySnapping(float value, float threshold)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_ApplySnapping_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x0002D0C4 File Offset: 0x0002B2C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 790844, RefRangeEnd = 790848, XrefRangeStart = 790844, XrefRangeEnd = 790844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TargetIsButton(InputControlType target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref target;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_TargetIsButton_Internal_Static_Boolean_InputControlType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x0002D104 File Offset: 0x0002B304
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 790848, RefRangeEnd = 790849, XrefRangeStart = 790848, XrefRangeEnd = 790848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TargetIsStandard(InputControlType target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref target;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_TargetIsStandard_Internal_Static_Boolean_InputControlType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x0002D144 File Offset: 0x0002B344
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 790849, RefRangeEnd = 790851, XrefRangeStart = 790849, XrefRangeEnd = 790849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TargetIsAlias(InputControlType target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref target;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_TargetIsAlias_Internal_Static_Boolean_InputControlType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x0002D184 File Offset: 0x0002B384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790851, XrefRangeEnd = 790855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReadFromFile(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_ReadFromFile_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x0002D1C0 File Offset: 0x0002B3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790855, XrefRangeEnd = 790869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteToFile(string path, string data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_WriteToFile_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x0002D208 File Offset: 0x0002B408
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 790869, RefRangeEnd = 790880, XrefRangeStart = 790869, XrefRangeEnd = 790869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Abs(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x0002D248 File Offset: 0x0002B448
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 786837, RefRangeEnd = 786838, XrefRangeStart = 786837, XrefRangeEnd = 786838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Approximately(float v1, float v2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x0002D294 File Offset: 0x0002B494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790880, XrefRangeEnd = 790885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Approximately(Vector2 v1, Vector2 v2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x0002D2E0 File Offset: 0x0002B4E0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 790885, RefRangeEnd = 790890, XrefRangeStart = 790885, XrefRangeEnd = 790885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNotZero(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_IsNotZero_Public_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x0002D320 File Offset: 0x0002B520
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 790890, RefRangeEnd = 790899, XrefRangeStart = 790890, XrefRangeEnd = 790890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsZero(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_IsZero_Public_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x0002D360 File Offset: 0x0002B560
		[CallerCount(0)]
		public unsafe static int Sign(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_Sign_Public_Static_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x0002D3A0 File Offset: 0x0002B5A0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 790899, RefRangeEnd = 790908, XrefRangeStart = 790899, XrefRangeEnd = 790899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AbsoluteIsOverThreshold(float value, float threshold)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_AbsoluteIsOverThreshold_Public_Static_Boolean_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x0002D3EC File Offset: 0x0002B5EC
		[CallerCount(0)]
		public unsafe static float NormalizeAngle(float angle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_NormalizeAngle_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x0002D42C File Offset: 0x0002B62C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 790917, RefRangeEnd = 790918, XrefRangeStart = 790908, XrefRangeEnd = 790917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float VectorToAngle(Vector2 vector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vector;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_VectorToAngle_Public_Static_Single_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x0002D46C File Offset: 0x0002B66C
		[CallerCount(0)]
		public unsafe static float Min(float v0, float v1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x0002D4B8 File Offset: 0x0002B6B8
		[CallerCount(0)]
		public unsafe static float Max(float v0, float v1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x0002D504 File Offset: 0x0002B704
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 790918, RefRangeEnd = 790921, XrefRangeStart = 790918, XrefRangeEnd = 790918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Min(float v0, float v1, float v2, float v3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x0002D56C File Offset: 0x0002B76C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 790921, RefRangeEnd = 790924, XrefRangeStart = 790921, XrefRangeEnd = 790921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Max(float v0, float v1, float v2, float v3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x0002D5D4 File Offset: 0x0002B7D4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 790927, RefRangeEnd = 790934, XrefRangeStart = 790924, XrefRangeEnd = 790927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ValueFromSides(float negativeSide, float positiveSide)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref negativeSide;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positiveSide;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_ValueFromSides_Internal_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x0002D620 File Offset: 0x0002B820
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 790940, RefRangeEnd = 790945, XrefRangeStart = 790934, XrefRangeEnd = 790940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ValueFromSides(float negativeSide, float positiveSide, bool invertSides)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref negativeSide;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positiveSide;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invertSides;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_ValueFromSides_Internal_Static_Single_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x0002D67C File Offset: 0x0002B87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790945, XrefRangeEnd = 790950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ArrayResize<T>(ref Il2CppArrayBase<T> array, int capacity)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Utility.MethodInfoStoreGeneric_ArrayResize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x0002D6D8 File Offset: 0x0002B8D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 790958, RefRangeEnd = 790960, XrefRangeStart = 790950, XrefRangeEnd = 790958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ArrayExpand<T>(ref Il2CppArrayBase<T> array, int capacity)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Utility.MethodInfoStoreGeneric_ArrayExpand_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x0002D734 File Offset: 0x0002B934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790960, XrefRangeEnd = 790966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ArrayAppend<T>(ref Il2CppArrayBase<T> array, T item)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t = item;
				intPtr2 = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref item;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Utility.MethodInfoStoreGeneric_ArrayAppend_Public_Static_Void_byref_Il2CppArrayBase_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			array = ((intPtr5 == 0) ? null : new Il2CppArrayBase<T>(intPtr5));
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x0002D7C8 File Offset: 0x0002B9C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790966, XrefRangeEnd = 790968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ArrayAppend<T>(ref Il2CppArrayBase<T> array, Il2CppArrayBase<T> items)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Utility.MethodInfoStoreGeneric_ArrayAppend_Public_Static_Void_byref_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0002D828 File Offset: 0x0002BA28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 790968, RefRangeEnd = 790970, XrefRangeStart = 790968, XrefRangeEnd = 790968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int NextPowerOfTwo(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_NextPowerOfTwo_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x0002D868 File Offset: 0x0002BA68
		public unsafe static bool Is32Bit
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790970, XrefRangeEnd = 790971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_get_Is32Bit_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x0002D898 File Offset: 0x0002BA98
		public unsafe static bool Is64Bit
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790971, XrefRangeEnd = 790972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_get_Is64Bit_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x0002D8C8 File Offset: 0x0002BAC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 790977, RefRangeEnd = 790978, XrefRangeStart = 790972, XrefRangeEnd = 790977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPlatformName(bool uppercase = true)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uppercase;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_GetPlatformName_Public_Static_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x0002D900 File Offset: 0x0002BB00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790978, XrefRangeEnd = 790986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetHumanUnderstandableWindowsVersion()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_GetHumanUnderstandableWindowsVersion_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x0002D92C File Offset: 0x0002BB2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 791033, RefRangeEnd = 791034, XrefRangeStart = 790986, XrefRangeEnd = 791033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetWindowsVersion()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_GetWindowsVersion_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x0002D958 File Offset: 0x0002BB58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 791035, RefRangeEnd = 791036, XrefRangeStart = 791034, XrefRangeEnd = 791035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSystemBuildNumber()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_GetSystemBuildNumber_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x0002D988 File Offset: 0x0002BB88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791036, XrefRangeEnd = 791040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadScene(string sceneName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_LoadScene_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x0002D9C0 File Offset: 0x0002BBC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791040, XrefRangeEnd = 791042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string PluginFileExtension()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_PluginFileExtension_Internal_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00005E6E File Offset: 0x0000406E
		public Utility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x0002D9EC File Offset: 0x0002BBEC
		// (set) Token: 0x06000A74 RID: 2676 RVA: 0x00005E77 File Offset: 0x00004077
		public unsafe static float Epsilon
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Utility.NativeFieldInfoPtr_Epsilon, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utility.NativeFieldInfoPtr_Epsilon, (void*)(&value));
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x0002DA08 File Offset: 0x0002BC08
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x00005E85 File Offset: 0x00004085
		public unsafe static Il2CppStructArray<Vector2> circleVertexList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utility.NativeFieldInfoPtr_circleVertexList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utility.NativeFieldInfoPtr_circleVertexList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeFieldInfoPtr_Epsilon;

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeFieldInfoPtr_circleVertexList;

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeMethodInfoPtr_DrawCircleGizmo_Public_Static_Void_Vector2_Single_0;

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeMethodInfoPtr_DrawCircleGizmo_Public_Static_Void_Vector2_Single_Color_0;

		// Token: 0x04000992 RID: 2450
		private static readonly IntPtr NativeMethodInfoPtr_DrawOvalGizmo_Public_Static_Void_Vector2_Vector2_0;

		// Token: 0x04000993 RID: 2451
		private static readonly IntPtr NativeMethodInfoPtr_DrawOvalGizmo_Public_Static_Void_Vector2_Vector2_Color_0;

		// Token: 0x04000994 RID: 2452
		private static readonly IntPtr NativeMethodInfoPtr_DrawRectGizmo_Public_Static_Void_Rect_0;

		// Token: 0x04000995 RID: 2453
		private static readonly IntPtr NativeMethodInfoPtr_DrawRectGizmo_Public_Static_Void_Rect_Color_0;

		// Token: 0x04000996 RID: 2454
		private static readonly IntPtr NativeMethodInfoPtr_DrawRectGizmo_Public_Static_Void_Vector2_Vector2_0;

		// Token: 0x04000997 RID: 2455
		private static readonly IntPtr NativeMethodInfoPtr_DrawRectGizmo_Public_Static_Void_Vector2_Vector2_Color_0;

		// Token: 0x04000998 RID: 2456
		private static readonly IntPtr NativeMethodInfoPtr_GameObjectIsCulledOnCurrentCamera_Public_Static_Boolean_GameObject_0;

		// Token: 0x04000999 RID: 2457
		private static readonly IntPtr NativeMethodInfoPtr_MoveColorTowards_Public_Static_Color_Color_Color_Single_0;

		// Token: 0x0400099A RID: 2458
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDeadZone_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x0400099B RID: 2459
		private static readonly IntPtr NativeMethodInfoPtr_ApplySmoothing_Public_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400099C RID: 2460
		private static readonly IntPtr NativeMethodInfoPtr_ApplySnapping_Public_Static_Single_Single_Single_0;

		// Token: 0x0400099D RID: 2461
		private static readonly IntPtr NativeMethodInfoPtr_TargetIsButton_Internal_Static_Boolean_InputControlType_0;

		// Token: 0x0400099E RID: 2462
		private static readonly IntPtr NativeMethodInfoPtr_TargetIsStandard_Internal_Static_Boolean_InputControlType_0;

		// Token: 0x0400099F RID: 2463
		private static readonly IntPtr NativeMethodInfoPtr_TargetIsAlias_Internal_Static_Boolean_InputControlType_0;

		// Token: 0x040009A0 RID: 2464
		private static readonly IntPtr NativeMethodInfoPtr_ReadFromFile_Public_Static_String_String_0;

		// Token: 0x040009A1 RID: 2465
		private static readonly IntPtr NativeMethodInfoPtr_WriteToFile_Public_Static_Void_String_String_0;

		// Token: 0x040009A2 RID: 2466
		private static readonly IntPtr NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0;

		// Token: 0x040009A3 RID: 2467
		private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0;

		// Token: 0x040009A4 RID: 2468
		private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Vector2_Vector2_0;

		// Token: 0x040009A5 RID: 2469
		private static readonly IntPtr NativeMethodInfoPtr_IsNotZero_Public_Static_Boolean_Single_0;

		// Token: 0x040009A6 RID: 2470
		private static readonly IntPtr NativeMethodInfoPtr_IsZero_Public_Static_Boolean_Single_0;

		// Token: 0x040009A7 RID: 2471
		private static readonly IntPtr NativeMethodInfoPtr_Sign_Public_Static_Int32_Single_0;

		// Token: 0x040009A8 RID: 2472
		private static readonly IntPtr NativeMethodInfoPtr_AbsoluteIsOverThreshold_Public_Static_Boolean_Single_Single_0;

		// Token: 0x040009A9 RID: 2473
		private static readonly IntPtr NativeMethodInfoPtr_NormalizeAngle_Public_Static_Single_Single_0;

		// Token: 0x040009AA RID: 2474
		private static readonly IntPtr NativeMethodInfoPtr_VectorToAngle_Public_Static_Single_Vector2_0;

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0;

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0;

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x040009AF RID: 2479
		private static readonly IntPtr NativeMethodInfoPtr_ValueFromSides_Internal_Static_Single_Single_Single_0;

		// Token: 0x040009B0 RID: 2480
		private static readonly IntPtr NativeMethodInfoPtr_ValueFromSides_Internal_Static_Single_Single_Single_Boolean_0;

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeMethodInfoPtr_ArrayResize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeMethodInfoPtr_ArrayExpand_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeMethodInfoPtr_ArrayAppend_Public_Static_Void_byref_Il2CppArrayBase_1_T_T_0;

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeMethodInfoPtr_ArrayAppend_Public_Static_Void_byref_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0;

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeMethodInfoPtr_NextPowerOfTwo_Public_Static_Int32_Int32_0;

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeMethodInfoPtr_get_Is32Bit_Internal_Static_get_Boolean_0;

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeMethodInfoPtr_get_Is64Bit_Internal_Static_get_Boolean_0;

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformName_Public_Static_String_Boolean_0;

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeMethodInfoPtr_GetHumanUnderstandableWindowsVersion_Private_Static_String_0;

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeMethodInfoPtr_GetWindowsVersion_Public_Static_String_0;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemBuildNumber_Public_Static_Int32_0;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeMethodInfoPtr_LoadScene_Public_Static_Void_String_0;

		// Token: 0x040009BD RID: 2493
		private static readonly IntPtr NativeMethodInfoPtr_PluginFileExtension_Internal_Static_String_0;

		// Token: 0x02000220 RID: 544
		private sealed class MethodInfoStoreGeneric_ArrayResize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x04000DFB RID: 3579
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Utility.NativeMethodInfoPtr_ArrayResize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<Utility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000221 RID: 545
		private sealed class MethodInfoStoreGeneric_ArrayExpand_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x04000DFC RID: 3580
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Utility.NativeMethodInfoPtr_ArrayExpand_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<Utility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000222 RID: 546
		private sealed class MethodInfoStoreGeneric_ArrayAppend_Public_Static_Void_byref_Il2CppArrayBase_1_T_T_0<T>
		{
			// Token: 0x04000DFD RID: 3581
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Utility.NativeMethodInfoPtr_ArrayAppend_Public_Static_Void_byref_Il2CppArrayBase_1_T_T_0, Il2CppClassPointerStore<Utility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000223 RID: 547
		private sealed class MethodInfoStoreGeneric_ArrayAppend_Public_Static_Void_byref_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04000DFE RID: 3582
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Utility.NativeMethodInfoPtr_ArrayAppend_Public_Static_Void_byref_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Utility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
