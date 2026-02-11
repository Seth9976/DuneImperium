using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace boardgames.attributes
{
	// Token: 0x02000162 RID: 354
	public class AttributeTextDisplaySubscriber : AttributeSubscriber
	{
		// Token: 0x060011FF RID: 4607 RVA: 0x000485A8 File Offset: 0x000467A8
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeTextDisplaySubscriber()
		{
			Il2CppClassPointerStore<AttributeTextDisplaySubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes", "AttributeTextDisplaySubscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeTextDisplaySubscriber>.NativeClassPtr);
			AttributeTextDisplaySubscriber.NativeFieldInfoPtr_display = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeTextDisplaySubscriber>.NativeClassPtr, "display");
			AttributeTextDisplaySubscriber.NativeFieldInfoPtr_format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeTextDisplaySubscriber>.NativeClassPtr, "format");
			AttributeTextDisplaySubscriber.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeTextDisplaySubscriber>.NativeClassPtr, 100665937);
			AttributeTextDisplaySubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeTextDisplaySubscriber>.NativeClassPtr, 100665938);
			AttributeTextDisplaySubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeTextDisplaySubscriber>.NativeClassPtr, 100665939);
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x0004863C File Offset: 0x0004683C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000549, XrefRangeEnd = 1000558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeTextDisplaySubscriber.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00048678 File Offset: 0x00046878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000558, XrefRangeEnd = 1000567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeTextDisplaySubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x000486B4 File Offset: 0x000468B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000567, XrefRangeEnd = 1000574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeTextDisplaySubscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeTextDisplaySubscriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeTextDisplaySubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x0000A689 File Offset: 0x00008889
		public AttributeTextDisplaySubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001204 RID: 4612 RVA: 0x000486F0 File Offset: 0x000468F0
		// (set) Token: 0x06001205 RID: 4613 RVA: 0x0000A692 File Offset: 0x00008892
		public unsafe TMP_Text display
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeTextDisplaySubscriber.NativeFieldInfoPtr_display);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeTextDisplaySubscriber.NativeFieldInfoPtr_display), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001206 RID: 4614 RVA: 0x00048720 File Offset: 0x00046920
		// (set) Token: 0x06001207 RID: 4615 RVA: 0x0000A6B1 File Offset: 0x000088B1
		public unsafe string format
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeTextDisplaySubscriber.NativeFieldInfoPtr_format);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeTextDisplaySubscriber.NativeFieldInfoPtr_format), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000AF2 RID: 2802
		private static readonly IntPtr NativeFieldInfoPtr_display;

		// Token: 0x04000AF3 RID: 2803
		private static readonly IntPtr NativeFieldInfoPtr_format;

		// Token: 0x04000AF4 RID: 2804
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000AF6 RID: 2806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
