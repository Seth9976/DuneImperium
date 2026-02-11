using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.ui.ugui.collections
{
	// Token: 0x0200001A RID: 26
	public class EventsForCanPageDisplay : VersionedView<IPaginatedDisplay>
	{
		// Token: 0x06000116 RID: 278 RVA: 0x00006488 File Offset: 0x00004688
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForCanPageDisplay()
		{
			Il2CppClassPointerStore<EventsForCanPageDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-ui.dll", "dwd.core.ui.ugui.collections", "EventsForCanPageDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForCanPageDisplay>.NativeClassPtr);
			EventsForCanPageDisplay.NativeFieldInfoPtr_onCanDecrement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForCanPageDisplay>.NativeClassPtr, "onCanDecrement");
			EventsForCanPageDisplay.NativeFieldInfoPtr_onCanIncrement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForCanPageDisplay>.NativeClassPtr, "onCanIncrement");
			EventsForCanPageDisplay.NativeFieldInfoPtr_cachedCanDecrement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForCanPageDisplay>.NativeClassPtr, "cachedCanDecrement");
			EventsForCanPageDisplay.NativeFieldInfoPtr_cachedCanIncrement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForCanPageDisplay>.NativeClassPtr, "cachedCanIncrement");
			EventsForCanPageDisplay.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForCanPageDisplay>.NativeClassPtr, 100663438);
			EventsForCanPageDisplay.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForCanPageDisplay>.NativeClassPtr, 100663439);
			EventsForCanPageDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForCanPageDisplay>.NativeClassPtr, 100663440);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00006544 File Offset: 0x00004744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254549, XrefRangeEnd = 1254555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForCanPageDisplay.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00006580 File Offset: 0x00004780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254555, XrefRangeEnd = 1254572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForCanPageDisplay.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000065BC File Offset: 0x000047BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254572, XrefRangeEnd = 1254584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForCanPageDisplay()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForCanPageDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForCanPageDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000027CE File Offset: 0x000009CE
		public EventsForCanPageDisplay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600011B RID: 283 RVA: 0x000065F8 File Offset: 0x000047F8
		// (set) Token: 0x0600011C RID: 284 RVA: 0x000027D7 File Offset: 0x000009D7
		public unsafe UnityEventBool onCanDecrement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForCanPageDisplay.NativeFieldInfoPtr_onCanDecrement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEventBool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForCanPageDisplay.NativeFieldInfoPtr_onCanDecrement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00006628 File Offset: 0x00004828
		// (set) Token: 0x0600011E RID: 286 RVA: 0x000027F6 File Offset: 0x000009F6
		public unsafe UnityEventBool onCanIncrement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForCanPageDisplay.NativeFieldInfoPtr_onCanIncrement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEventBool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForCanPageDisplay.NativeFieldInfoPtr_onCanIncrement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00006658 File Offset: 0x00004858
		// (set) Token: 0x06000120 RID: 288 RVA: 0x00002815 File Offset: 0x00000A15
		public Nullable<bool> cachedCanDecrement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForCanPageDisplay.NativeFieldInfoPtr_cachedCanDecrement);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForCanPageDisplay.NativeFieldInfoPtr_cachedCanDecrement), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00006688 File Offset: 0x00004888
		// (set) Token: 0x06000122 RID: 290 RVA: 0x00002843 File Offset: 0x00000A43
		public Nullable<bool> cachedCanIncrement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForCanPageDisplay.NativeFieldInfoPtr_cachedCanIncrement);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForCanPageDisplay.NativeFieldInfoPtr_cachedCanIncrement), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeFieldInfoPtr_onCanDecrement;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeFieldInfoPtr_onCanIncrement;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeFieldInfoPtr_cachedCanDecrement;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeFieldInfoPtr_cachedCanIncrement;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
