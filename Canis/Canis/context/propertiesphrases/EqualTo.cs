using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.context.propertiesphrases
{
	// Token: 0x02000138 RID: 312
	[Serializable]
	public class EqualTo : PropertiesPhrase
	{
		// Token: 0x06000E26 RID: 3622 RVA: 0x00055828 File Offset: 0x00053A28
		// Note: this type is marked as 'beforefieldinit'.
		static EqualTo()
		{
			Il2CppClassPointerStore<EqualTo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.propertiesphrases", "EqualTo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualTo>.NativeClassPtr);
			EqualTo.NativeFieldInfoPtr_first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualTo>.NativeClassPtr, "first");
			EqualTo.NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualTo>.NativeClassPtr, "second");
			EqualTo.NativeMethodInfoPtr__ctor_Public_Void_ContextToInt_ContextToInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualTo>.NativeClassPtr, 100666396);
			EqualTo.NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualTo>.NativeClassPtr, 100666397);
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x000558A8 File Offset: 0x00053AA8
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EqualTo(ContextToInt first, ContextToInt second)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualTo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualTo.NativeMethodInfoPtr__ctor_Public_Void_ContextToInt_ContextToInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x00055908 File Offset: 0x00053B08
		[CallerCount(0)]
		public unsafe override bool Evaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EqualTo.NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x00007294 File Offset: 0x00005494
		public EqualTo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000E2A RID: 3626 RVA: 0x00055960 File Offset: 0x00053B60
		// (set) Token: 0x06000E2B RID: 3627 RVA: 0x0000729D File Offset: 0x0000549D
		public unsafe ContextToInt first
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqualTo.NativeFieldInfoPtr_first);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextToInt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqualTo.NativeFieldInfoPtr_first), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000E2C RID: 3628 RVA: 0x00055990 File Offset: 0x00053B90
		// (set) Token: 0x06000E2D RID: 3629 RVA: 0x000072BC File Offset: 0x000054BC
		public unsafe ContextToInt second
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqualTo.NativeFieldInfoPtr_second);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextToInt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EqualTo.NativeFieldInfoPtr_second), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400099B RID: 2459
		private static readonly IntPtr NativeFieldInfoPtr_first;

		// Token: 0x0400099C RID: 2460
		private static readonly IntPtr NativeFieldInfoPtr_second;

		// Token: 0x0400099D RID: 2461
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ContextToInt_ContextToInt_0;

		// Token: 0x0400099E RID: 2462
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0;
	}
}
