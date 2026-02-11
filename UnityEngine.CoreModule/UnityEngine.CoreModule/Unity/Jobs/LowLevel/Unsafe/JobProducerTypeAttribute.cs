using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Jobs.LowLevel.Unsafe
{
	// Token: 0x02000010 RID: 16
	public sealed class JobProducerTypeAttribute : Attribute
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00017974 File Offset: 0x00015B74
		// Note: this type is marked as 'beforefieldinit'.
		static JobProducerTypeAttribute()
		{
			Il2CppClassPointerStore<JobProducerTypeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs.LowLevel.Unsafe", "JobProducerTypeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobProducerTypeAttribute>.NativeClassPtr);
			JobProducerTypeAttribute.NativeFieldInfoPtr__ProducerType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobProducerTypeAttribute>.NativeClassPtr, "<ProducerType>k__BackingField");
			JobProducerTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobProducerTypeAttribute>.NativeClassPtr, 100663343);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000179CC File Offset: 0x00015BCC
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JobProducerTypeAttribute(Type producerType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JobProducerTypeAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(producerType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JobProducerTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000022F0 File Offset: 0x000004F0
		public JobProducerTypeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00017A18 File Offset: 0x00015C18
		// (set) Token: 0x0600005B RID: 91 RVA: 0x000022F9 File Offset: 0x000004F9
		public unsafe Type _ProducerType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JobProducerTypeAttribute.NativeFieldInfoPtr__ProducerType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JobProducerTypeAttribute.NativeFieldInfoPtr__ProducerType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00002318 File Offset: 0x00000518
		public Type ProducerType
		{
			get
			{
				return this._ProducerType_k__BackingField;
			}
		}

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr__ProducerType_k__BackingField;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
