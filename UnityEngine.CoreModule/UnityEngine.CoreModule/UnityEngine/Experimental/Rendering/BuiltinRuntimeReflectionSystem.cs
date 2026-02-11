using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x0200027E RID: 638
	public class BuiltinRuntimeReflectionSystem : Object
	{
		// Token: 0x06002B72 RID: 11122 RVA: 0x000AFD24 File Offset: 0x000ADF24
		// Note: this type is marked as 'beforefieldinit'.
		static BuiltinRuntimeReflectionSystem()
		{
			Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Rendering", "BuiltinRuntimeReflectionSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr);
			BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_TickRealtimeProbes_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr, 100668628);
			BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr, 100668629);
			BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr, 100668630);
			BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_BuiltinUpdate_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr, 100668631);
			BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_Internal_BuiltinRuntimeReflectionSystem_New_Private_Static_BuiltinRuntimeReflectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr, 100668632);
			BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr, 100668633);
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x000AFDCC File Offset: 0x000ADFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686207, XrefRangeEnd = 686209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TickRealtimeProbes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_TickRealtimeProbes_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x000AFE08 File Offset: 0x000AE008
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x000AFE3C File Offset: 0x000AE03C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x000AFE7C File Offset: 0x000AE07C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BuiltinUpdate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_BuiltinUpdate_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B77 RID: 11127 RVA: 0x000AFEAC File Offset: 0x000AE0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686209, XrefRangeEnd = 686213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_Internal_BuiltinRuntimeReflectionSystem_New_Private_Static_BuiltinRuntimeReflectionSystem_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BuiltinRuntimeReflectionSystem>(intPtr3) : null;
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x000AFEE0 File Offset: 0x000AE0E0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuiltinRuntimeReflectionSystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x00010F5A File Offset: 0x0000F15A
		public BuiltinRuntimeReflectionSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002675 RID: 9845
		private static readonly IntPtr NativeMethodInfoPtr_TickRealtimeProbes_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04002676 RID: 9846
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002677 RID: 9847
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x04002678 RID: 9848
		private static readonly IntPtr NativeMethodInfoPtr_BuiltinUpdate_Private_Static_Boolean_0;

		// Token: 0x04002679 RID: 9849
		private static readonly IntPtr NativeMethodInfoPtr_Internal_BuiltinRuntimeReflectionSystem_New_Private_Static_BuiltinRuntimeReflectionSystem_0;

		// Token: 0x0400267A RID: 9850
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
