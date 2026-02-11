using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.context.propertiesphrases
{
	// Token: 0x02000143 RID: 323
	[Serializable]
	public class True : PropertiesPhrase
	{
		// Token: 0x06000E70 RID: 3696 RVA: 0x0005682C File Offset: 0x00054A2C
		// Note: this type is marked as 'beforefieldinit'.
		static True()
		{
			Il2CppClassPointerStore<True>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.propertiesphrases", "True");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<True>.NativeClassPtr);
			True.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<True>.NativeClassPtr, "Instance");
			True.NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<True>.NativeClassPtr, 100666425);
			True.NativeMethodInfoPtr_op_LogicalNot_Public_Static_PropertiesPhrase_True_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<True>.NativeClassPtr, 100666426);
			True.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<True>.NativeClassPtr, 100666427);
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x000568AC File Offset: 0x00054AAC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Evaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), True.NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00056904 File Offset: 0x00054B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577430, XrefRangeEnd = 577434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertiesPhrase operator !(True _)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(True.NativeMethodInfoPtr_op_LogicalNot_Public_Static_PropertiesPhrase_True_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertiesPhrase>(intPtr3) : null;
			}
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00056948 File Offset: 0x00054B48
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe True()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<True>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(True.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x0000748B File Offset: 0x0000568B
		public True(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000E75 RID: 3701 RVA: 0x00056984 File Offset: 0x00054B84
		// (set) Token: 0x06000E76 RID: 3702 RVA: 0x00007494 File Offset: 0x00005694
		public unsafe static True Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(True.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<True>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(True.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009C0 RID: 2496
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0;

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeMethodInfoPtr_op_LogicalNot_Public_Static_PropertiesPhrase_True_0;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
