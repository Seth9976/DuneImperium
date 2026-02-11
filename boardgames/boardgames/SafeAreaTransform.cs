using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;
using UnityEngine.UI;

namespace boardgames
{
	// Token: 0x02000104 RID: 260
	public class SafeAreaTransform : DirtyBehaviour
	{
		// Token: 0x06000C9A RID: 3226 RVA: 0x0003904C File Offset: 0x0003724C
		// Note: this type is marked as 'beforefieldinit'.
		static SafeAreaTransform()
		{
			Il2CppClassPointerStore<SafeAreaTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames", "SafeAreaTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeAreaTransform>.NativeClassPtr);
			SafeAreaTransform.NativeFieldInfoPtr_percentages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeAreaTransform>.NativeClassPtr, "percentages");
			SafeAreaTransform.NativeFieldInfoPtr_sam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeAreaTransform>.NativeClassPtr, "sam");
			SafeAreaTransform.NativeFieldInfoPtr_um = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeAreaTransform>.NativeClassPtr, "um");
			SafeAreaTransform.NativeFieldInfoPtr_rootCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeAreaTransform>.NativeClassPtr, "rootCanvas");
			SafeAreaTransform.NativeFieldInfoPtr_canvasScaler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeAreaTransform>.NativeClassPtr, "canvasScaler");
			SafeAreaTransform.NativeFieldInfoPtr_canvasTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeAreaTransform>.NativeClassPtr, "canvasTransform");
			SafeAreaTransform.NativeFieldInfoPtr_rt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeAreaTransform>.NativeClassPtr, "rt");
			SafeAreaTransform.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAreaTransform>.NativeClassPtr, 100665284);
			SafeAreaTransform.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAreaTransform>.NativeClassPtr, 100665285);
			SafeAreaTransform.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAreaTransform>.NativeClassPtr, 100665286);
			SafeAreaTransform.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAreaTransform>.NativeClassPtr, 100665287);
			SafeAreaTransform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeAreaTransform>.NativeClassPtr, 100665288);
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x0003916C File Offset: 0x0003736C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995706, XrefRangeEnd = 995710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAreaTransform.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x000391A0 File Offset: 0x000373A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995710, XrefRangeEnd = 995727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAreaTransform.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x000391D4 File Offset: 0x000373D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995727, XrefRangeEnd = 995737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAreaTransform.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x00039208 File Offset: 0x00037408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995737, XrefRangeEnd = 995777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeAreaTransform.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00039244 File Offset: 0x00037444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995777, XrefRangeEnd = 995778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeAreaTransform()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeAreaTransform>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeAreaTransform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00007CD2 File Offset: 0x00005ED2
		public SafeAreaTransform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x00039280 File Offset: 0x00037480
		// (set) Token: 0x06000CA2 RID: 3234 RVA: 0x00007CDB File Offset: 0x00005EDB
		public unsafe Rect percentages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAreaTransform.NativeFieldInfoPtr_percentages);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAreaTransform.NativeFieldInfoPtr_percentages)) = value;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x000392A8 File Offset: 0x000374A8
		// (set) Token: 0x06000CA4 RID: 3236 RVA: 0x00007CF6 File Offset: 0x00005EF6
		public unsafe SafeAreaManager sam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAreaTransform.NativeFieldInfoPtr_sam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SafeAreaManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAreaTransform.NativeFieldInfoPtr_sam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x000392D8 File Offset: 0x000374D8
		// (set) Token: 0x06000CA6 RID: 3238 RVA: 0x00007D15 File Offset: 0x00005F15
		public unsafe UpdateManager um
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAreaTransform.NativeFieldInfoPtr_um);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAreaTransform.NativeFieldInfoPtr_um), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x00039308 File Offset: 0x00037508
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x00007D34 File Offset: 0x00005F34
		public unsafe Canvas rootCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAreaTransform.NativeFieldInfoPtr_rootCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAreaTransform.NativeFieldInfoPtr_rootCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x00039338 File Offset: 0x00037538
		// (set) Token: 0x06000CAA RID: 3242 RVA: 0x00007D53 File Offset: 0x00005F53
		public unsafe CanvasScaler canvasScaler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAreaTransform.NativeFieldInfoPtr_canvasScaler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasScaler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAreaTransform.NativeFieldInfoPtr_canvasScaler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x00039368 File Offset: 0x00037568
		// (set) Token: 0x06000CAC RID: 3244 RVA: 0x00007D72 File Offset: 0x00005F72
		public unsafe RectTransform canvasTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAreaTransform.NativeFieldInfoPtr_canvasTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAreaTransform.NativeFieldInfoPtr_canvasTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x00039398 File Offset: 0x00037598
		// (set) Token: 0x06000CAE RID: 3246 RVA: 0x00007D91 File Offset: 0x00005F91
		public unsafe RectTransform rt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAreaTransform.NativeFieldInfoPtr_rt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeAreaTransform.NativeFieldInfoPtr_rt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeFieldInfoPtr_percentages;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeFieldInfoPtr_sam;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeFieldInfoPtr_um;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeFieldInfoPtr_rootCanvas;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeFieldInfoPtr_canvasScaler;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeFieldInfoPtr_canvasTransform;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeFieldInfoPtr_rt;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
