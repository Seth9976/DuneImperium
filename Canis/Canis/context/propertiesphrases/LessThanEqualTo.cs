using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.context.propertiesphrases
{
	// Token: 0x0200013A RID: 314
	[Serializable]
	public class LessThanEqualTo : PropertiesPhrase
	{
		// Token: 0x06000E36 RID: 3638 RVA: 0x00055B58 File Offset: 0x00053D58
		// Note: this type is marked as 'beforefieldinit'.
		static LessThanEqualTo()
		{
			Il2CppClassPointerStore<LessThanEqualTo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.propertiesphrases", "LessThanEqualTo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LessThanEqualTo>.NativeClassPtr);
			LessThanEqualTo.NativeFieldInfoPtr_first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanEqualTo>.NativeClassPtr, "first");
			LessThanEqualTo.NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanEqualTo>.NativeClassPtr, "second");
			LessThanEqualTo.NativeMethodInfoPtr__ctor_Public_Void_ContextToInt_ContextToInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanEqualTo>.NativeClassPtr, 100666400);
			LessThanEqualTo.NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanEqualTo>.NativeClassPtr, 100666401);
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x00055BD8 File Offset: 0x00053DD8
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LessThanEqualTo(ContextToInt first, ContextToInt second)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LessThanEqualTo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanEqualTo.NativeMethodInfoPtr__ctor_Public_Void_ContextToInt_ContextToInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x00055C38 File Offset: 0x00053E38
		[CallerCount(0)]
		public unsafe override bool Evaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LessThanEqualTo.NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x00007322 File Offset: 0x00005522
		public LessThanEqualTo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x00055C90 File Offset: 0x00053E90
		// (set) Token: 0x06000E3B RID: 3643 RVA: 0x0000732B File Offset: 0x0000552B
		public unsafe ContextToInt first
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LessThanEqualTo.NativeFieldInfoPtr_first);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextToInt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LessThanEqualTo.NativeFieldInfoPtr_first), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x00055CC0 File Offset: 0x00053EC0
		// (set) Token: 0x06000E3D RID: 3645 RVA: 0x0000734A File Offset: 0x0000554A
		public unsafe ContextToInt second
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LessThanEqualTo.NativeFieldInfoPtr_second);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextToInt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LessThanEqualTo.NativeFieldInfoPtr_second), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009A3 RID: 2467
		private static readonly IntPtr NativeFieldInfoPtr_first;

		// Token: 0x040009A4 RID: 2468
		private static readonly IntPtr NativeFieldInfoPtr_second;

		// Token: 0x040009A5 RID: 2469
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ContextToInt_ContextToInt_0;

		// Token: 0x040009A6 RID: 2470
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0;
	}
}
