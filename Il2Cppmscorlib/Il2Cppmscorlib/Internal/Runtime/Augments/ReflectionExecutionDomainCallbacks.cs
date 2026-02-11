using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Internal.Runtime.Augments
{
	// Token: 0x02000053 RID: 83
	public class ReflectionExecutionDomainCallbacks : Object
	{
		// Token: 0x06000426 RID: 1062 RVA: 0x0003612C File Offset: 0x0003432C
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionExecutionDomainCallbacks()
		{
			Il2CppClassPointerStore<ReflectionExecutionDomainCallbacks>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Internal.Runtime.Augments", "ReflectionExecutionDomainCallbacks");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionExecutionDomainCallbacks>.NativeClassPtr);
			ReflectionExecutionDomainCallbacks.NativeMethodInfoPtr_CreateMissingMetadataException_Internal_Exception_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionExecutionDomainCallbacks>.NativeClassPtr, 100663921);
			ReflectionExecutionDomainCallbacks.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionExecutionDomainCallbacks>.NativeClassPtr, 100663922);
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00036184 File Offset: 0x00034384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281170, XrefRangeEnd = 1281174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception CreateMissingMetadataException(Type attributeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionExecutionDomainCallbacks.NativeMethodInfoPtr_CreateMissingMetadataException_Internal_Exception_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x000361D4 File Offset: 0x000343D4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionExecutionDomainCallbacks()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionExecutionDomainCallbacks>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionExecutionDomainCallbacks.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0000380A File Offset: 0x00001A0A
		public ReflectionExecutionDomainCallbacks(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_CreateMissingMetadataException_Internal_Exception_Type_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
