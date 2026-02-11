using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using offlineChallenges;

namespace zen.analytics.messages
{
	// Token: 0x02000090 RID: 144
	public class AnalyticsChallengeComplete : StandardAnalyticsMessage
	{
		// Token: 0x06000721 RID: 1825 RVA: 0x0002767C File Offset: 0x0002587C
		// Note: this type is marked as 'beforefieldinit'.
		static AnalyticsChallengeComplete()
		{
			Il2CppClassPointerStore<AnalyticsChallengeComplete>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.analytics.messages", "AnalyticsChallengeComplete");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsChallengeComplete>.NativeClassPtr);
			AnalyticsChallengeComplete.NativeMethodInfoPtr_get_eventName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsChallengeComplete>.NativeClassPtr, 100664457);
			AnalyticsChallengeComplete.NativeMethodInfoPtr__ctor_Public_Void_ChallengeDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsChallengeComplete>.NativeClassPtr, 100664458);
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x000276D4 File Offset: 0x000258D4
		public unsafe override string eventName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990121, XrefRangeEnd = 990123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnalyticsChallengeComplete.NativeMethodInfoPtr_get_eventName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00027718 File Offset: 0x00025918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 990158, RefRangeEnd = 990159, XrefRangeStart = 990123, XrefRangeEnd = 990158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalyticsChallengeComplete(ChallengeDefinition challenge, string game)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsChallengeComplete>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(challenge);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(game);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsChallengeComplete.NativeMethodInfoPtr__ctor_Public_Void_ChallengeDefinition_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x000052B9 File Offset: 0x000034B9
		public AnalyticsChallengeComplete(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr_get_eventName_Protected_Virtual_get_String_0;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ChallengeDefinition_String_0;
	}
}
