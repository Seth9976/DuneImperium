using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000174 RID: 372
	public static class UIRUtility : Object
	{
		// Token: 0x06001B9E RID: 7070 RVA: 0x0007E4F0 File Offset: 0x0007C6F0
		// Note: this type is marked as 'beforefieldinit'.
		static UIRUtility()
		{
			Il2CppClassPointerStore<UIRUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UIRUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIRUtility>.NativeClassPtr);
			UIRUtility.NativeFieldInfoPtr_k_DefaultShaderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRUtility>.NativeClassPtr, "k_DefaultShaderName");
			UIRUtility.NativeFieldInfoPtr_k_DefaultWorldSpaceShaderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRUtility>.NativeClassPtr, "k_DefaultWorldSpaceShaderName");
			UIRUtility.NativeMethodInfoPtr_ShapeWindingIsClockwise_Public_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRUtility>.NativeClassPtr, 100667309);
			UIRUtility.NativeMethodInfoPtr_IsRoundRect_Public_Static_Boolean_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRUtility>.NativeClassPtr, 100667310);
			UIRUtility.NativeMethodInfoPtr_IsVectorImageBackground_Public_Static_Boolean_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRUtility>.NativeClassPtr, 100667311);
			UIRUtility.NativeMethodInfoPtr_IsElementSelfHidden_Public_Static_Boolean_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRUtility>.NativeClassPtr, 100667312);
			UIRUtility.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRUtility>.NativeClassPtr, 100667313);
			UIRUtility.NativeMethodInfoPtr_GetPrevPow2_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRUtility>.NativeClassPtr, 100667314);
			UIRUtility.NativeMethodInfoPtr_GetNextPow2_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRUtility>.NativeClassPtr, 100667315);
			UIRUtility.NativeMethodInfoPtr_GetNextPow2Exp_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRUtility>.NativeClassPtr, 100667316);
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x0007E5E8 File Offset: 0x0007C7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323309, XrefRangeEnd = 323314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShapeWindingIsClockwise(int maskDepth, int stencilRef)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maskDepth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stencilRef;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRUtility.NativeMethodInfoPtr_ShapeWindingIsClockwise_Public_Static_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x0007E634 File Offset: 0x0007C834
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 323324, RefRangeEnd = 323326, XrefRangeStart = 323314, XrefRangeEnd = 323324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsRoundRect(VisualElement ve)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRUtility.NativeMethodInfoPtr_IsRoundRect_Public_Static_Boolean_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x0007E678 File Offset: 0x0007C878
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 323333, RefRangeEnd = 323336, XrefRangeStart = 323326, XrefRangeEnd = 323333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsVectorImageBackground(VisualElement ve)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRUtility.NativeMethodInfoPtr_IsVectorImageBackground_Public_Static_Boolean_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x0007E6BC File Offset: 0x0007C8BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323340, RefRangeEnd = 323341, XrefRangeStart = 323336, XrefRangeEnd = 323340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsElementSelfHidden(VisualElement ve)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRUtility.NativeMethodInfoPtr_IsElementSelfHidden_Public_Static_Boolean_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x0007E700 File Offset: 0x0007C900
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 323354, RefRangeEnd = 323372, XrefRangeStart = 323341, XrefRangeEnd = 323354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Destroy(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRUtility.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x0007E738 File Offset: 0x0007C938
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 323372, RefRangeEnd = 323374, XrefRangeStart = 323372, XrefRangeEnd = 323372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPrevPow2(int n)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRUtility.NativeMethodInfoPtr_GetPrevPow2_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x0007E778 File Offset: 0x0007C978
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 323374, RefRangeEnd = 323378, XrefRangeStart = 323374, XrefRangeEnd = 323374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNextPow2(int n)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRUtility.NativeMethodInfoPtr_GetNextPow2_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x0007E7B8 File Offset: 0x0007C9B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 323378, RefRangeEnd = 323382, XrefRangeStart = 323378, XrefRangeEnd = 323378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNextPow2Exp(int n)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRUtility.NativeMethodInfoPtr_GetNextPow2Exp_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x0000C852 File Offset: 0x0000AA52
		public UIRUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x0007E7F8 File Offset: 0x0007C9F8
		// (set) Token: 0x06001BA9 RID: 7081 RVA: 0x0000C85B File Offset: 0x0000AA5B
		public unsafe static string k_DefaultShaderName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIRUtility.NativeFieldInfoPtr_k_DefaultShaderName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRUtility.NativeFieldInfoPtr_k_DefaultShaderName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06001BAA RID: 7082 RVA: 0x0007E818 File Offset: 0x0007CA18
		// (set) Token: 0x06001BAB RID: 7083 RVA: 0x0000C86D File Offset: 0x0000AA6D
		public unsafe static string k_DefaultWorldSpaceShaderName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIRUtility.NativeFieldInfoPtr_k_DefaultWorldSpaceShaderName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRUtility.NativeFieldInfoPtr_k_DefaultWorldSpaceShaderName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x0007E838 File Offset: 0x0007CA38
		public static Vector4 ToVector4(Rect rc)
		{
			return new Vector4(rc.xMin, rc.yMin, rc.xMax, rc.yMax);
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x0007E86C File Offset: 0x0007CA6C
		public static void Multiply2D(Quaternion rotation, ref Vector2 point)
		{
			float num = rotation.z * 2f;
			float num2 = 1f - rotation.z * num;
			float num3 = rotation.w * num;
			point = new Vector2(num2 * point.x - num3 * point.y, num3 * point.x + num2 * point.y);
		}

		// Token: 0x0400130E RID: 4878
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultShaderName;

		// Token: 0x0400130F RID: 4879
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultWorldSpaceShaderName;

		// Token: 0x04001310 RID: 4880
		private static readonly IntPtr NativeMethodInfoPtr_ShapeWindingIsClockwise_Public_Static_Boolean_Int32_Int32_0;

		// Token: 0x04001311 RID: 4881
		private static readonly IntPtr NativeMethodInfoPtr_IsRoundRect_Public_Static_Boolean_VisualElement_0;

		// Token: 0x04001312 RID: 4882
		private static readonly IntPtr NativeMethodInfoPtr_IsVectorImageBackground_Public_Static_Boolean_VisualElement_0;

		// Token: 0x04001313 RID: 4883
		private static readonly IntPtr NativeMethodInfoPtr_IsElementSelfHidden_Public_Static_Boolean_VisualElement_0;

		// Token: 0x04001314 RID: 4884
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0;

		// Token: 0x04001315 RID: 4885
		private static readonly IntPtr NativeMethodInfoPtr_GetPrevPow2_Public_Static_Int32_Int32_0;

		// Token: 0x04001316 RID: 4886
		private static readonly IntPtr NativeMethodInfoPtr_GetNextPow2_Public_Static_Int32_Int32_0;

		// Token: 0x04001317 RID: 4887
		private static readonly IntPtr NativeMethodInfoPtr_GetNextPow2Exp_Public_Static_Int32_Int32_0;

		// Token: 0x04001318 RID: 4888
		public const float k_Epsilon = 1E-30f;

		// Token: 0x04001319 RID: 4889
		public const float k_ClearZ = 0.99f;

		// Token: 0x0400131A RID: 4890
		public const float k_MeshPosZ = 0f;

		// Token: 0x0400131B RID: 4891
		public const float k_MaskPosZ = 1f;

		// Token: 0x0400131C RID: 4892
		public const int k_MaxMaskDepth = 7;
	}
}
