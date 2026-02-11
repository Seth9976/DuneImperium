using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace worm.menus.components
{
	// Token: 0x020000A0 RID: 160
	public class WormPerLangageURLObject : MonoBehaviour
	{
		// Token: 0x06000649 RID: 1609 RVA: 0x0002BC98 File Offset: 0x00029E98
		// Note: this type is marked as 'beforefieldinit'.
		static WormPerLangageURLObject()
		{
			Il2CppClassPointerStore<WormPerLangageURLObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.components", "WormPerLangageURLObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPerLangageURLObject>.NativeClassPtr);
			WormPerLangageURLObject.NativeFieldInfoPtr_urls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPerLangageURLObject>.NativeClassPtr, "urls");
			WormPerLangageURLObject.NativeMethodInfoPtr_get_currentPair_Private_get_LanguageURLPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPerLangageURLObject>.NativeClassPtr, 100664179);
			WormPerLangageURLObject.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPerLangageURLObject>.NativeClassPtr, 100664180);
			WormPerLangageURLObject.NativeMethodInfoPtr_Event_OpenURL_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPerLangageURLObject>.NativeClassPtr, 100664181);
			WormPerLangageURLObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPerLangageURLObject>.NativeClassPtr, 100664182);
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x0002BD2C File Offset: 0x00029F2C
		public unsafe LanguageURLPair currentPair
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696174, XrefRangeEnd = 696192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPerLangageURLObject.NativeMethodInfoPtr_get_currentPair_Private_get_LanguageURLPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LanguageURLPair>(intPtr3) : null;
			}
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0002BD6C File Offset: 0x00029F6C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPerLangageURLObject.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0002BDA0 File Offset: 0x00029FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696192, XrefRangeEnd = 696221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OpenURL()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPerLangageURLObject.NativeMethodInfoPtr_Event_OpenURL_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0002BDD4 File Offset: 0x00029FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696221, XrefRangeEnd = 696226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPerLangageURLObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPerLangageURLObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPerLangageURLObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x0000528A File Offset: 0x0000348A
		public WormPerLangageURLObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x0002BE10 File Offset: 0x0002A010
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x00005293 File Offset: 0x00003493
		public unsafe Il2CppReferenceArray<LanguageURLPair> urls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPerLangageURLObject.NativeFieldInfoPtr_urls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LanguageURLPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPerLangageURLObject.NativeFieldInfoPtr_urls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeFieldInfoPtr_urls;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeMethodInfoPtr_get_currentPair_Private_get_LanguageURLPair_0;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeMethodInfoPtr_Event_OpenURL_Public_Void_0;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200030B RID: 779
		[ObfuscatedName("worm.menus.components.WormPerLangageURLObject+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06001F73 RID: 8051 RVA: 0x000783B8 File Offset: 0x000765B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormPerLangageURLObject.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPerLangageURLObject>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPerLangageURLObject.__c>.NativeClassPtr);
				WormPerLangageURLObject.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPerLangageURLObject.__c>.NativeClassPtr, "<>9");
				WormPerLangageURLObject.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPerLangageURLObject.__c>.NativeClassPtr, "<>9__2_0");
				WormPerLangageURLObject.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPerLangageURLObject.__c>.NativeClassPtr, 100664184);
				WormPerLangageURLObject.__c.NativeMethodInfoPtr__get_currentPair_b__2_0_Internal_Boolean_LanguageURLPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPerLangageURLObject.__c>.NativeClassPtr, 100664185);
			}

			// Token: 0x06001F74 RID: 8052 RVA: 0x00078434 File Offset: 0x00076634
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPerLangageURLObject.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPerLangageURLObject.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F75 RID: 8053 RVA: 0x00078470 File Offset: 0x00076670
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696167, XrefRangeEnd = 696174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_currentPair_b__2_0(LanguageURLPair u)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(u);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPerLangageURLObject.__c.NativeMethodInfoPtr__get_currentPair_b__2_0_Internal_Boolean_LanguageURLPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001F76 RID: 8054 RVA: 0x00011BFD File Offset: 0x0000FDFD
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700089C RID: 2204
			// (get) Token: 0x06001F77 RID: 8055 RVA: 0x000784C0 File Offset: 0x000766C0
			// (set) Token: 0x06001F78 RID: 8056 RVA: 0x00011C06 File Offset: 0x0000FE06
			public unsafe static WormPerLangageURLObject.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPerLangageURLObject.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPerLangageURLObject.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPerLangageURLObject.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700089D RID: 2205
			// (get) Token: 0x06001F79 RID: 8057 RVA: 0x000784E8 File Offset: 0x000766E8
			// (set) Token: 0x06001F7A RID: 8058 RVA: 0x00011C18 File Offset: 0x0000FE18
			public unsafe static Func<LanguageURLPair, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPerLangageURLObject.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<LanguageURLPair, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPerLangageURLObject.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400122D RID: 4653
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400122E RID: 4654
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x0400122F RID: 4655
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001230 RID: 4656
			private static readonly IntPtr NativeMethodInfoPtr__get_currentPair_b__2_0_Internal_Boolean_LanguageURLPair_0;
		}
	}
}
