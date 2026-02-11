using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Networking.game;

namespace boardgames.data
{
	// Token: 0x02000189 RID: 393
	public class PendingGameData<T> : PendingGameData where T : MatchInitData
	{
		// Token: 0x0600116C RID: 4460 RVA: 0x00054D40 File Offset: 0x00052F40
		// Note: this type is marked as 'beforefieldinit'.
		static PendingGameData()
		{
			Il2CppClassPointerStore<PendingGameData<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "PendingGameData`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PendingGameData<T>>.NativeClassPtr);
			PendingGameData<T>.NativeMethodInfoPtr__ctor_Protected_Void_DWDPendingGameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData<T>>.NativeClassPtr, 100665744);
			PendingGameData<T>.NativeMethodInfoPtr_deserializeMatchInitData_Protected_Virtual_Final_MatchInitData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGameData<T>>.NativeClassPtr, 100665745);
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x00054DD4 File Offset: 0x00052FD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 515055, RefRangeEnd = 515057, XrefRangeStart = 515054, XrefRangeEnd = 515055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PendingGameData(DWDPendingGameMetadata gameMetadata)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PendingGameData<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameMetadata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData<T>.NativeMethodInfoPtr__ctor_Protected_Void_DWDPendingGameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x00054E20 File Offset: 0x00053020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515057, XrefRangeEnd = 515063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MatchInitData deserializeMatchInitData(string matchInitDataString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(matchInitDataString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGameData<T>.NativeMethodInfoPtr_deserializeMatchInitData_Protected_Virtual_Final_MatchInitData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr3) : null;
			}
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x0000A5CD File Offset: 0x000087CD
		public PendingGameData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AA5 RID: 2725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_DWDPendingGameMetadata_0;

		// Token: 0x04000AA6 RID: 2726
		private static readonly IntPtr NativeMethodInfoPtr_deserializeMatchInitData_Protected_Virtual_Final_MatchInitData_String_0;
	}
}
