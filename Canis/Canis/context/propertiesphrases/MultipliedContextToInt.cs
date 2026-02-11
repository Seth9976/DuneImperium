using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.context.propertiesphrases
{
	// Token: 0x02000137 RID: 311
	[Serializable]
	public class MultipliedContextToInt : ContextToInt
	{
		// Token: 0x06000E1E RID: 3614 RVA: 0x00055690 File Offset: 0x00053890
		// Note: this type is marked as 'beforefieldinit'.
		static MultipliedContextToInt()
		{
			Il2CppClassPointerStore<MultipliedContextToInt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.propertiesphrases", "MultipliedContextToInt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipliedContextToInt>.NativeClassPtr);
			MultipliedContextToInt.NativeFieldInfoPtr_first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipliedContextToInt>.NativeClassPtr, "first");
			MultipliedContextToInt.NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipliedContextToInt>.NativeClassPtr, "second");
			MultipliedContextToInt.NativeMethodInfoPtr__ctor_Public_Void_ContextToInt_ContextToInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipliedContextToInt>.NativeClassPtr, 100666394);
			MultipliedContextToInt.NativeMethodInfoPtr_Evaluate_Public_Virtual_Int32_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipliedContextToInt>.NativeClassPtr, 100666395);
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00055710 File Offset: 0x00053910
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultipliedContextToInt(ContextToInt first, ContextToInt second)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipliedContextToInt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipliedContextToInt.NativeMethodInfoPtr__ctor_Public_Void_ContextToInt_ContextToInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x00055770 File Offset: 0x00053970
		[CallerCount(0)]
		public unsafe override int Evaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipliedContextToInt.NativeMethodInfoPtr_Evaluate_Public_Virtual_Int32_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x0000724D File Offset: 0x0000544D
		public MultipliedContextToInt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x000557C8 File Offset: 0x000539C8
		// (set) Token: 0x06000E23 RID: 3619 RVA: 0x00007256 File Offset: 0x00005456
		public unsafe ContextToInt first
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipliedContextToInt.NativeFieldInfoPtr_first);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextToInt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipliedContextToInt.NativeFieldInfoPtr_first), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000E24 RID: 3620 RVA: 0x000557F8 File Offset: 0x000539F8
		// (set) Token: 0x06000E25 RID: 3621 RVA: 0x00007275 File Offset: 0x00005475
		public unsafe ContextToInt second
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipliedContextToInt.NativeFieldInfoPtr_second);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextToInt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipliedContextToInt.NativeFieldInfoPtr_second), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000997 RID: 2455
		private static readonly IntPtr NativeFieldInfoPtr_first;

		// Token: 0x04000998 RID: 2456
		private static readonly IntPtr NativeFieldInfoPtr_second;

		// Token: 0x04000999 RID: 2457
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ContextToInt_ContextToInt_0;

		// Token: 0x0400099A RID: 2458
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_Int32_Context_0;
	}
}
