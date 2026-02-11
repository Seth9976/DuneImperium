using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Canis.match
{
	// Token: 0x02000098 RID: 152
	public static class MakesPlayerMatchHistoryExtensions : Object
	{
		// Token: 0x06000795 RID: 1941 RVA: 0x00004EC0 File Offset: 0x000030C0
		// Note: this type is marked as 'beforefieldinit'.
		static MakesPlayerMatchHistoryExtensions()
		{
			Il2CppClassPointerStore<MakesPlayerMatchHistoryExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.match", "MakesPlayerMatchHistoryExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MakesPlayerMatchHistoryExtensions>.NativeClassPtr);
			MakesPlayerMatchHistoryExtensions.NativeMethodInfoPtr_ResignedFromGame_Public_Static_Boolean_TGameResultsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MakesPlayerMatchHistoryExtensions>.NativeClassPtr, 100664853);
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00038360 File Offset: 0x00036560
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 557983, RefRangeEnd = 557984, XrefRangeStart = 557983, XrefRangeEnd = 557983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ResignedFromGame<TGameResultsEntry, TGameResults>(this TGameResultsEntry playerResult) where TGameResultsEntry : DBGGameResultsEntry where TGameResults : DBGGameResults
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TGameResultsEntry).IsValueType)
				{
					TGameResultsEntry tgameResultsEntry = playerResult;
					intPtr = ((tgameResultsEntry is string) ? IL2CPP.ManagedStringToIl2Cpp(tgameResultsEntry as string) : IL2CPP.Il2CppObjectBaseToPtr(tgameResultsEntry as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref playerResult;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MakesPlayerMatchHistoryExtensions.MethodInfoStoreGeneric_ResignedFromGame_Public_Static_Boolean_TGameResultsEntry_0<TGameResultsEntry, TGameResults>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00004EF9 File Offset: 0x000030F9
		public MakesPlayerMatchHistoryExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeMethodInfoPtr_ResignedFromGame_Public_Static_Boolean_TGameResultsEntry_0;

		// Token: 0x020002DD RID: 733
		private sealed class MethodInfoStoreGeneric_ResignedFromGame_Public_Static_Boolean_TGameResultsEntry_0<TGameResultsEntry, TGameResults>
		{
			// Token: 0x04001367 RID: 4967
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MakesPlayerMatchHistoryExtensions.NativeMethodInfoPtr_ResignedFromGame_Public_Static_Boolean_TGameResultsEntry_0, Il2CppClassPointerStore<MakesPlayerMatchHistoryExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGameResultsEntry>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGameResults>.NativeClassPtr))
			}))));
		}
	}
}
