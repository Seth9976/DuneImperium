using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Networking.selection.targetinformation
{
	// Token: 0x0200006C RID: 108
	public class FlippableTarget : Object
	{
		// Token: 0x06000392 RID: 914 RVA: 0x0000F23C File Offset: 0x0000D43C
		// Note: this type is marked as 'beforefieldinit'.
		static FlippableTarget()
		{
			Il2CppClassPointerStore<FlippableTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetinformation", "FlippableTarget");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlippableTarget>.NativeClassPtr);
			FlippableTarget.NativeFieldInfoPtr_Space = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlippableTarget>.NativeClassPtr, "Space");
			FlippableTarget.NativeFieldInfoPtr_Orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlippableTarget>.NativeClassPtr, "Orientation");
			FlippableTarget.NativeFieldInfoPtr_Flip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlippableTarget>.NativeClassPtr, "Flip");
			FlippableTarget.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_EntityID_byref_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlippableTarget>.NativeClassPtr, 100663499);
			FlippableTarget.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlippableTarget>.NativeClassPtr, 100663500);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000F2D0 File Offset: 0x0000D4D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1194258, RefRangeEnd = 1194259, XrefRangeStart = 1194257, XrefRangeEnd = 1194258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deconstruct(out EntityID spaceid, out int orientation, out bool flip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &orientation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &flip;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FlippableTarget.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_EntityID_byref_Int32_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			spaceid = ((intPtr4 == 0) ? null : new EntityID(intPtr4));
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000F340 File Offset: 0x0000D540
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlippableTarget()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlippableTarget>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlippableTarget.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x000044AB File Offset: 0x000026AB
		public FlippableTarget(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000396 RID: 918 RVA: 0x0000F37C File Offset: 0x0000D57C
		// (set) Token: 0x06000397 RID: 919 RVA: 0x000044B4 File Offset: 0x000026B4
		public unsafe EntityID Space
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlippableTarget.NativeFieldInfoPtr_Space);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlippableTarget.NativeFieldInfoPtr_Space), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000398 RID: 920 RVA: 0x0000F3AC File Offset: 0x0000D5AC
		// (set) Token: 0x06000399 RID: 921 RVA: 0x000044D3 File Offset: 0x000026D3
		public unsafe int Orientation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlippableTarget.NativeFieldInfoPtr_Orientation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlippableTarget.NativeFieldInfoPtr_Orientation)) = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600039A RID: 922 RVA: 0x0000F3D4 File Offset: 0x0000D5D4
		// (set) Token: 0x0600039B RID: 923 RVA: 0x000044EE File Offset: 0x000026EE
		public unsafe int Flip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlippableTarget.NativeFieldInfoPtr_Flip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlippableTarget.NativeFieldInfoPtr_Flip)) = value;
			}
		}

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeFieldInfoPtr_Space;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeFieldInfoPtr_Orientation;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeFieldInfoPtr_Flip;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_Deconstruct_Public_Void_byref_EntityID_byref_Int32_byref_Boolean_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
