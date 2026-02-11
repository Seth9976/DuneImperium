using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.context.propertiesphrases
{
	// Token: 0x02000144 RID: 324
	[Serializable]
	public class False : PropertiesPhrase
	{
		// Token: 0x06000E77 RID: 3703 RVA: 0x000569AC File Offset: 0x00054BAC
		// Note: this type is marked as 'beforefieldinit'.
		static False()
		{
			Il2CppClassPointerStore<False>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.propertiesphrases", "False");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<False>.NativeClassPtr);
			False.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<False>.NativeClassPtr, "Instance");
			False.NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<False>.NativeClassPtr, 100666429);
			False.NativeMethodInfoPtr_op_LogicalNot_Public_Static_PropertiesPhrase_False_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<False>.NativeClassPtr, 100666430);
			False.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<False>.NativeClassPtr, 100666431);
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x00056A2C File Offset: 0x00054C2C
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Evaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), False.NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00056A84 File Offset: 0x00054C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577434, XrefRangeEnd = 577438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertiesPhrase operator !(False _)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(False.NativeMethodInfoPtr_op_LogicalNot_Public_Static_PropertiesPhrase_False_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertiesPhrase>(intPtr3) : null;
			}
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00056AC8 File Offset: 0x00054CC8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe False()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<False>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(False.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x000074A6 File Offset: 0x000056A6
		public False(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x00056B04 File Offset: 0x00054D04
		// (set) Token: 0x06000E7D RID: 3709 RVA: 0x000074AF File Offset: 0x000056AF
		public unsafe static False Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(False.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<False>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(False.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeMethodInfoPtr_op_LogicalNot_Public_Static_PropertiesPhrase_False_0;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
