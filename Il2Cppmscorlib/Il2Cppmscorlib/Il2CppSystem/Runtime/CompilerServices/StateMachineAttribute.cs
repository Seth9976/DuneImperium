using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003C3 RID: 963
	[Serializable]
	public class StateMachineAttribute : Attribute
	{
		// Token: 0x06003945 RID: 14661 RVA: 0x00115658 File Offset: 0x00113858
		// Note: this type is marked as 'beforefieldinit'.
		static StateMachineAttribute()
		{
			Il2CppClassPointerStore<StateMachineAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "StateMachineAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateMachineAttribute>.NativeClassPtr);
			StateMachineAttribute.NativeFieldInfoPtr__StateMachineType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineAttribute>.NativeClassPtr, "<StateMachineType>k__BackingField");
			StateMachineAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAttribute>.NativeClassPtr, 100671841);
			StateMachineAttribute.NativeMethodInfoPtr_get_StateMachineType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAttribute>.NativeClassPtr, 100671842);
		}

		// Token: 0x06003946 RID: 14662 RVA: 0x001156C4 File Offset: 0x001138C4
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StateMachineAttribute(Type stateMachineType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachineType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x06003947 RID: 14663 RVA: 0x00115710 File Offset: 0x00113910
		public unsafe Type StateMachineType
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAttribute.NativeMethodInfoPtr_get_StateMachineType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003948 RID: 14664 RVA: 0x0001531E File Offset: 0x0001351E
		public StateMachineAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06003949 RID: 14665 RVA: 0x00115750 File Offset: 0x00113950
		// (set) Token: 0x0600394A RID: 14666 RVA: 0x00015327 File Offset: 0x00013527
		public unsafe Type _StateMachineType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAttribute.NativeFieldInfoPtr__StateMachineType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAttribute.NativeFieldInfoPtr__StateMachineType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002E94 RID: 11924
		private static readonly IntPtr NativeFieldInfoPtr__StateMachineType_k__BackingField;

		// Token: 0x04002E95 RID: 11925
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

		// Token: 0x04002E96 RID: 11926
		private static readonly IntPtr NativeMethodInfoPtr_get_StateMachineType_Public_get_Type_0;
	}
}
