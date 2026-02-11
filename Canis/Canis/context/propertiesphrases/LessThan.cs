using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.context.propertiesphrases
{
	// Token: 0x02000139 RID: 313
	[Serializable]
	public class LessThan : PropertiesPhrase
	{
		// Token: 0x06000E2E RID: 3630 RVA: 0x000559C0 File Offset: 0x00053BC0
		// Note: this type is marked as 'beforefieldinit'.
		static LessThan()
		{
			Il2CppClassPointerStore<LessThan>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.propertiesphrases", "LessThan");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LessThan>.NativeClassPtr);
			LessThan.NativeFieldInfoPtr_first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThan>.NativeClassPtr, "first");
			LessThan.NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThan>.NativeClassPtr, "second");
			LessThan.NativeMethodInfoPtr__ctor_Public_Void_ContextToInt_ContextToInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThan>.NativeClassPtr, 100666398);
			LessThan.NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThan>.NativeClassPtr, 100666399);
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x00055A40 File Offset: 0x00053C40
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LessThan(ContextToInt first, ContextToInt second)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LessThan>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThan.NativeMethodInfoPtr__ctor_Public_Void_ContextToInt_ContextToInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x00055AA0 File Offset: 0x00053CA0
		[CallerCount(0)]
		public unsafe override bool Evaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LessThan.NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x000072DB File Offset: 0x000054DB
		public LessThan(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000E32 RID: 3634 RVA: 0x00055AF8 File Offset: 0x00053CF8
		// (set) Token: 0x06000E33 RID: 3635 RVA: 0x000072E4 File Offset: 0x000054E4
		public unsafe ContextToInt first
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LessThan.NativeFieldInfoPtr_first);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextToInt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LessThan.NativeFieldInfoPtr_first), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000E34 RID: 3636 RVA: 0x00055B28 File Offset: 0x00053D28
		// (set) Token: 0x06000E35 RID: 3637 RVA: 0x00007303 File Offset: 0x00005503
		public unsafe ContextToInt second
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LessThan.NativeFieldInfoPtr_second);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextToInt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LessThan.NativeFieldInfoPtr_second), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400099F RID: 2463
		private static readonly IntPtr NativeFieldInfoPtr_first;

		// Token: 0x040009A0 RID: 2464
		private static readonly IntPtr NativeFieldInfoPtr_second;

		// Token: 0x040009A1 RID: 2465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ContextToInt_ContextToInt_0;

		// Token: 0x040009A2 RID: 2466
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0;
	}
}
