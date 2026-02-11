using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	public static class SubsystemDescriptorBindings : Object
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00002BA8 File Offset: 0x00000DA8
		// Note: this type is marked as 'beforefieldinit'.
		static SubsystemDescriptorBindings()
		{
			Il2CppClassPointerStore<SubsystemDescriptorBindings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine", "SubsystemDescriptorBindings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubsystemDescriptorBindings>.NativeClassPtr);
			SubsystemDescriptorBindings.NativeMethodInfoPtr_GetId_Public_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemDescriptorBindings>.NativeClassPtr, 100663306);
			SubsystemDescriptorBindings.CreateDelegateField = IL2CPP.ResolveICall<SubsystemDescriptorBindings.CreateDelegate>("UnityEngine.SubsystemDescriptorBindings::Create");
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002BFC File Offset: 0x00000DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270148, XrefRangeEnd = 1270150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetId(IntPtr descriptorPtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref descriptorPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemDescriptorBindings.NativeMethodInfoPtr_GetId_Public_Static_String_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000211B File Offset: 0x0000031B
		public SubsystemDescriptorBindings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002124 File Offset: 0x00000324
		public static IntPtr Create(IntPtr descriptorPtr)
		{
			return SubsystemDescriptorBindings.CreateDelegateField(descriptorPtr);
		}

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_GetId_Public_Static_String_IntPtr_0;

		// Token: 0x04000010 RID: 16
		private static readonly SubsystemDescriptorBindings.CreateDelegate CreateDelegateField;

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x0600009F RID: 159
		private delegate IntPtr CreateDelegate(IntPtr descriptorPtr);
	}
}
