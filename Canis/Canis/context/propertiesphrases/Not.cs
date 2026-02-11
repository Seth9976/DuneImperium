using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.context.propertiesphrases
{
	// Token: 0x02000145 RID: 325
	[Serializable]
	public class Not : PropertiesPhrase
	{
		// Token: 0x06000E7E RID: 3710 RVA: 0x00056B2C File Offset: 0x00054D2C
		// Note: this type is marked as 'beforefieldinit'.
		static Not()
		{
			Il2CppClassPointerStore<Not>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.propertiesphrases", "Not");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Not>.NativeClassPtr);
			Not.NativeFieldInfoPtr_condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Not>.NativeClassPtr, "condition");
			Not.NativeMethodInfoPtr__ctor_Public_Void_PropertiesPhrase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Not>.NativeClassPtr, 100666433);
			Not.NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Not>.NativeClassPtr, 100666434);
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x00056B98 File Offset: 0x00054D98
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Not(PropertiesPhrase condition)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Not>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(condition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Not.NativeMethodInfoPtr__ctor_Public_Void_PropertiesPhrase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00056BE4 File Offset: 0x00054DE4
		[CallerCount(0)]
		public unsafe override bool Evaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Not.NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x000074C1 File Offset: 0x000056C1
		public Not(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000E82 RID: 3714 RVA: 0x00056C3C File Offset: 0x00054E3C
		// (set) Token: 0x06000E83 RID: 3715 RVA: 0x000074CA File Offset: 0x000056CA
		public unsafe PropertiesPhrase condition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Not.NativeFieldInfoPtr_condition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertiesPhrase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Not.NativeFieldInfoPtr_condition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeFieldInfoPtr_condition;

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PropertiesPhrase_0;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0;
	}
}
