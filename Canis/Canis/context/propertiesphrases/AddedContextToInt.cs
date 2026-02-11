using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.context.propertiesphrases
{
	// Token: 0x02000136 RID: 310
	[Serializable]
	public class AddedContextToInt : ContextToInt
	{
		// Token: 0x06000E16 RID: 3606 RVA: 0x000554F8 File Offset: 0x000536F8
		// Note: this type is marked as 'beforefieldinit'.
		static AddedContextToInt()
		{
			Il2CppClassPointerStore<AddedContextToInt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.propertiesphrases", "AddedContextToInt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddedContextToInt>.NativeClassPtr);
			AddedContextToInt.NativeFieldInfoPtr_first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddedContextToInt>.NativeClassPtr, "first");
			AddedContextToInt.NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddedContextToInt>.NativeClassPtr, "second");
			AddedContextToInt.NativeMethodInfoPtr__ctor_Public_Void_ContextToInt_ContextToInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddedContextToInt>.NativeClassPtr, 100666392);
			AddedContextToInt.NativeMethodInfoPtr_Evaluate_Public_Virtual_Int32_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddedContextToInt>.NativeClassPtr, 100666393);
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00055578 File Offset: 0x00053778
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddedContextToInt(ContextToInt first, ContextToInt second)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddedContextToInt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddedContextToInt.NativeMethodInfoPtr__ctor_Public_Void_ContextToInt_ContextToInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x000555D8 File Offset: 0x000537D8
		[CallerCount(0)]
		public unsafe override int Evaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddedContextToInt.NativeMethodInfoPtr_Evaluate_Public_Virtual_Int32_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00007206 File Offset: 0x00005406
		public AddedContextToInt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x00055630 File Offset: 0x00053830
		// (set) Token: 0x06000E1B RID: 3611 RVA: 0x0000720F File Offset: 0x0000540F
		public unsafe ContextToInt first
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddedContextToInt.NativeFieldInfoPtr_first);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextToInt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddedContextToInt.NativeFieldInfoPtr_first), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000E1C RID: 3612 RVA: 0x00055660 File Offset: 0x00053860
		// (set) Token: 0x06000E1D RID: 3613 RVA: 0x0000722E File Offset: 0x0000542E
		public unsafe ContextToInt second
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddedContextToInt.NativeFieldInfoPtr_second);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextToInt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddedContextToInt.NativeFieldInfoPtr_second), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000993 RID: 2451
		private static readonly IntPtr NativeFieldInfoPtr_first;

		// Token: 0x04000994 RID: 2452
		private static readonly IntPtr NativeFieldInfoPtr_second;

		// Token: 0x04000995 RID: 2453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ContextToInt_ContextToInt_0;

		// Token: 0x04000996 RID: 2454
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_Int32_Context_0;
	}
}
