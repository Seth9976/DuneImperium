using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000073 RID: 115
	public sealed class RaycastResult : ValueType
	{
		// Token: 0x06000B73 RID: 2931 RVA: 0x00033928 File Offset: 0x00031B28
		// Note: this type is marked as 'beforefieldinit'.
		static RaycastResult()
		{
			Il2CppClassPointerStore<RaycastResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "RaycastResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr);
			RaycastResult.NativeFieldInfoPtr_m_GameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "m_GameObject");
			RaycastResult.NativeFieldInfoPtr_module = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "module");
			RaycastResult.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "distance");
			RaycastResult.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "index");
			RaycastResult.NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "depth");
			RaycastResult.NativeFieldInfoPtr_sortingGroupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "sortingGroupID");
			RaycastResult.NativeFieldInfoPtr_sortingGroupOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "sortingGroupOrder");
			RaycastResult.NativeFieldInfoPtr_sortingLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "sortingLayer");
			RaycastResult.NativeFieldInfoPtr_sortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "sortingOrder");
			RaycastResult.NativeFieldInfoPtr_worldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "worldPosition");
			RaycastResult.NativeFieldInfoPtr_worldNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "worldNormal");
			RaycastResult.NativeFieldInfoPtr_screenPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "screenPosition");
			RaycastResult.NativeFieldInfoPtr_displayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "displayIndex");
			RaycastResult.NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, 100665177);
			RaycastResult.NativeMethodInfoPtr_set_gameObject_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, 100665178);
			RaycastResult.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, 100665179);
			RaycastResult.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, 100665180);
			RaycastResult.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, 100665181);
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000B74 RID: 2932 RVA: 0x00033AC0 File Offset: 0x00031CC0
		// (set) Token: 0x06000B75 RID: 2933 RVA: 0x00033B04 File Offset: 0x00031D04
		public unsafe GameObject gameObject
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastResult.NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastResult.NativeMethodInfoPtr_set_gameObject_Public_set_Void_GameObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x00033B4C File Offset: 0x00031D4C
		public unsafe bool isValid
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1097749, RefRangeEnd = 1097750, XrefRangeStart = 1097745, XrefRangeEnd = 1097749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastResult.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00033B90 File Offset: 0x00031D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097750, XrefRangeEnd = 1097758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastResult.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00033BC8 File Offset: 0x00031DC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1097823, RefRangeEnd = 1097825, XrefRangeStart = 1097758, XrefRangeEnd = 1097823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastResult.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x000060C6 File Offset: 0x000042C6
		public RaycastResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x000060CF File Offset: 0x000042CF
		public RaycastResult()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr))
		{
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x00033C04 File Offset: 0x00031E04
		// (set) Token: 0x06000B7C RID: 2940 RVA: 0x000060E1 File Offset: 0x000042E1
		public unsafe GameObject m_GameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_m_GameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_m_GameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x00033C34 File Offset: 0x00031E34
		// (set) Token: 0x06000B7E RID: 2942 RVA: 0x00006100 File Offset: 0x00004300
		public unsafe BaseRaycaster module
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_module);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseRaycaster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_module), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x00033C64 File Offset: 0x00031E64
		// (set) Token: 0x06000B80 RID: 2944 RVA: 0x0000611F File Offset: 0x0000431F
		public unsafe float distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_distance)) = value;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x00033C8C File Offset: 0x00031E8C
		// (set) Token: 0x06000B82 RID: 2946 RVA: 0x0000613A File Offset: 0x0000433A
		public unsafe float index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x00033CB4 File Offset: 0x00031EB4
		// (set) Token: 0x06000B84 RID: 2948 RVA: 0x00006155 File Offset: 0x00004355
		public unsafe int depth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_depth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_depth)) = value;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x00033CDC File Offset: 0x00031EDC
		// (set) Token: 0x06000B86 RID: 2950 RVA: 0x00006170 File Offset: 0x00004370
		public unsafe int sortingGroupID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_sortingGroupID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_sortingGroupID)) = value;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x00033D04 File Offset: 0x00031F04
		// (set) Token: 0x06000B88 RID: 2952 RVA: 0x0000618B File Offset: 0x0000438B
		public unsafe int sortingGroupOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_sortingGroupOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_sortingGroupOrder)) = value;
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x00033D2C File Offset: 0x00031F2C
		// (set) Token: 0x06000B8A RID: 2954 RVA: 0x000061A6 File Offset: 0x000043A6
		public unsafe int sortingLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_sortingLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_sortingLayer)) = value;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000B8B RID: 2955 RVA: 0x00033D54 File Offset: 0x00031F54
		// (set) Token: 0x06000B8C RID: 2956 RVA: 0x000061C1 File Offset: 0x000043C1
		public unsafe int sortingOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_sortingOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_sortingOrder)) = value;
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000B8D RID: 2957 RVA: 0x00033D7C File Offset: 0x00031F7C
		// (set) Token: 0x06000B8E RID: 2958 RVA: 0x000061DC File Offset: 0x000043DC
		public unsafe Vector3 worldPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_worldPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_worldPosition)) = value;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000B8F RID: 2959 RVA: 0x00033DA4 File Offset: 0x00031FA4
		// (set) Token: 0x06000B90 RID: 2960 RVA: 0x000061F7 File Offset: 0x000043F7
		public unsafe Vector3 worldNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_worldNormal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_worldNormal)) = value;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000B91 RID: 2961 RVA: 0x00033DCC File Offset: 0x00031FCC
		// (set) Token: 0x06000B92 RID: 2962 RVA: 0x00006212 File Offset: 0x00004412
		public unsafe Vector2 screenPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_screenPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_screenPosition)) = value;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000B93 RID: 2963 RVA: 0x00033DF4 File Offset: 0x00031FF4
		// (set) Token: 0x06000B94 RID: 2964 RVA: 0x0000622D File Offset: 0x0000442D
		public unsafe int displayIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_displayIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_displayIndex)) = value;
			}
		}

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeFieldInfoPtr_m_GameObject;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeFieldInfoPtr_module;

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeFieldInfoPtr_distance;

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeFieldInfoPtr_depth;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeFieldInfoPtr_sortingGroupID;

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeFieldInfoPtr_sortingGroupOrder;

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeFieldInfoPtr_sortingLayer;

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeFieldInfoPtr_sortingOrder;

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeFieldInfoPtr_worldPosition;

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeFieldInfoPtr_worldNormal;

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeFieldInfoPtr_screenPosition;

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeFieldInfoPtr_displayIndex;

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0;

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeMethodInfoPtr_set_gameObject_Public_set_Void_GameObject_0;

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0;

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
