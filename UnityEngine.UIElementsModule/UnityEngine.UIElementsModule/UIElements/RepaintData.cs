using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000158 RID: 344
	public class RepaintData : Object
	{
		// Token: 0x060018CD RID: 6349 RVA: 0x00074A44 File Offset: 0x00072C44
		// Note: this type is marked as 'beforefieldinit'.
		static RepaintData()
		{
			Il2CppClassPointerStore<RepaintData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "RepaintData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RepaintData>.NativeClassPtr);
			RepaintData.NativeFieldInfoPtr__currentOffset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepaintData>.NativeClassPtr, "<currentOffset>k__BackingField");
			RepaintData.NativeFieldInfoPtr__mousePosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepaintData>.NativeClassPtr, "<mousePosition>k__BackingField");
			RepaintData.NativeFieldInfoPtr__currentWorldClip_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepaintData>.NativeClassPtr, "<currentWorldClip>k__BackingField");
			RepaintData.NativeFieldInfoPtr__repaintEvent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepaintData>.NativeClassPtr, "<repaintEvent>k__BackingField");
			RepaintData.NativeMethodInfoPtr_get_currentOffset_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepaintData>.NativeClassPtr, 100666950);
			RepaintData.NativeMethodInfoPtr_get_currentWorldClip_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepaintData>.NativeClassPtr, 100666951);
			RepaintData.NativeMethodInfoPtr_get_repaintEvent_Public_get_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepaintData>.NativeClassPtr, 100666952);
			RepaintData.NativeMethodInfoPtr_set_repaintEvent_Public_set_Void_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepaintData>.NativeClassPtr, 100666953);
			RepaintData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepaintData>.NativeClassPtr, 100666954);
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x060018CE RID: 6350 RVA: 0x00074B28 File Offset: 0x00072D28
		// (set) Token: 0x060018DC RID: 6364 RVA: 0x0000B674 File Offset: 0x00009874
		public unsafe Matrix4x4 currentOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RepaintData.NativeMethodInfoPtr_get_currentOffset_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._currentOffset_k__BackingField = value;
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x060018CF RID: 6351 RVA: 0x00074B64 File Offset: 0x00072D64
		// (set) Token: 0x060018DF RID: 6367 RVA: 0x0000B68E File Offset: 0x0000988E
		public unsafe Rect currentWorldClip
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RepaintData.NativeMethodInfoPtr_get_currentWorldClip_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._currentWorldClip_k__BackingField = value;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x060018D0 RID: 6352 RVA: 0x00074BA0 File Offset: 0x00072DA0
		// (set) Token: 0x060018D1 RID: 6353 RVA: 0x00074BE0 File Offset: 0x00072DE0
		public unsafe Event repaintEvent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RepaintData.NativeMethodInfoPtr_get_repaintEvent_Public_get_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Event>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RepaintData.NativeMethodInfoPtr_set_repaintEvent_Public_set_Void_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x00074C24 File Offset: 0x00072E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320531, XrefRangeEnd = 320534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RepaintData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RepaintData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RepaintData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x0000B5FB File Offset: 0x000097FB
		public RepaintData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x060018D4 RID: 6356 RVA: 0x00074C60 File Offset: 0x00072E60
		// (set) Token: 0x060018D5 RID: 6357 RVA: 0x0000B604 File Offset: 0x00009804
		public unsafe Matrix4x4 _currentOffset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepaintData.NativeFieldInfoPtr__currentOffset_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepaintData.NativeFieldInfoPtr__currentOffset_k__BackingField)) = value;
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x060018D6 RID: 6358 RVA: 0x00074C88 File Offset: 0x00072E88
		// (set) Token: 0x060018D7 RID: 6359 RVA: 0x0000B61F File Offset: 0x0000981F
		public unsafe Vector2 _mousePosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepaintData.NativeFieldInfoPtr__mousePosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepaintData.NativeFieldInfoPtr__mousePosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x060018D8 RID: 6360 RVA: 0x00074CB0 File Offset: 0x00072EB0
		// (set) Token: 0x060018D9 RID: 6361 RVA: 0x0000B63A File Offset: 0x0000983A
		public unsafe Rect _currentWorldClip_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepaintData.NativeFieldInfoPtr__currentWorldClip_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepaintData.NativeFieldInfoPtr__currentWorldClip_k__BackingField)) = value;
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x060018DA RID: 6362 RVA: 0x00074CD8 File Offset: 0x00072ED8
		// (set) Token: 0x060018DB RID: 6363 RVA: 0x0000B655 File Offset: 0x00009855
		public unsafe Event _repaintEvent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepaintData.NativeFieldInfoPtr__repaintEvent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Event>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RepaintData.NativeFieldInfoPtr__repaintEvent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x060018DD RID: 6365 RVA: 0x0000B67D File Offset: 0x0000987D
		// (set) Token: 0x060018DE RID: 6366 RVA: 0x0000B685 File Offset: 0x00009885
		public Vector2 mousePosition
		{
			get
			{
				return this._mousePosition_k__BackingField;
			}
			set
			{
				this._mousePosition_k__BackingField = value;
			}
		}

		// Token: 0x04001139 RID: 4409
		private static readonly IntPtr NativeFieldInfoPtr__currentOffset_k__BackingField;

		// Token: 0x0400113A RID: 4410
		private static readonly IntPtr NativeFieldInfoPtr__mousePosition_k__BackingField;

		// Token: 0x0400113B RID: 4411
		private static readonly IntPtr NativeFieldInfoPtr__currentWorldClip_k__BackingField;

		// Token: 0x0400113C RID: 4412
		private static readonly IntPtr NativeFieldInfoPtr__repaintEvent_k__BackingField;

		// Token: 0x0400113D RID: 4413
		private static readonly IntPtr NativeMethodInfoPtr_get_currentOffset_Public_get_Matrix4x4_0;

		// Token: 0x0400113E RID: 4414
		private static readonly IntPtr NativeMethodInfoPtr_get_currentWorldClip_Public_get_Rect_0;

		// Token: 0x0400113F RID: 4415
		private static readonly IntPtr NativeMethodInfoPtr_get_repaintEvent_Public_get_Event_0;

		// Token: 0x04001140 RID: 4416
		private static readonly IntPtr NativeMethodInfoPtr_set_repaintEvent_Public_set_Void_Event_0;

		// Token: 0x04001141 RID: 4417
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
