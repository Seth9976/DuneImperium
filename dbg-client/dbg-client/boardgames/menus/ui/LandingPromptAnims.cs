using System;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.menus.ui
{
	// Token: 0x020001AF RID: 431
	public class LandingPromptAnims : PromptAnims
	{
		// Token: 0x0600135E RID: 4958 RVA: 0x0005C4B4 File Offset: 0x0005A6B4
		// Note: this type is marked as 'beforefieldinit'.
		static LandingPromptAnims()
		{
			Il2CppClassPointerStore<LandingPromptAnims>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.ui", "LandingPromptAnims");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandingPromptAnims>.NativeClassPtr);
			LandingPromptAnims.NativeFieldInfoPtr_requiredScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingPromptAnims>.NativeClassPtr, "requiredScene");
			LandingPromptAnims.NativeMethodInfoPtr_AnimateOpen_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingPromptAnims>.NativeClassPtr, 100666163);
			LandingPromptAnims.NativeMethodInfoPtr_sceneLoaded_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingPromptAnims>.NativeClassPtr, 100666164);
			LandingPromptAnims.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingPromptAnims>.NativeClassPtr, 100666165);
			LandingPromptAnims.NativeMethodInfoPtr___n__0_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingPromptAnims>.NativeClassPtr, 100666166);
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x0005C548 File Offset: 0x0005A748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519356, XrefRangeEnd = 519361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator AnimateOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandingPromptAnims.NativeMethodInfoPtr_AnimateOpen_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x0005C594 File Offset: 0x0005A794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519361, XrefRangeEnd = 519370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool sceneLoaded(string sceneName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingPromptAnims.NativeMethodInfoPtr_sceneLoaded_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x0005C5E4 File Offset: 0x0005A7E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519370, XrefRangeEnd = 519375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandingPromptAnims()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandingPromptAnims>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingPromptAnims.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x0005C620 File Offset: 0x0005A820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519375, XrefRangeEnd = 519376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator __n__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingPromptAnims.NativeMethodInfoPtr___n__0_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x0000B150 File Offset: 0x00009350
		public LandingPromptAnims(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06001364 RID: 4964 RVA: 0x0005C660 File Offset: 0x0005A860
		// (set) Token: 0x06001365 RID: 4965 RVA: 0x0000B159 File Offset: 0x00009359
		public unsafe string requiredScene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingPromptAnims.NativeFieldInfoPtr_requiredScene);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingPromptAnims.NativeFieldInfoPtr_requiredScene), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000BF5 RID: 3061
		private static readonly IntPtr NativeFieldInfoPtr_requiredScene;

		// Token: 0x04000BF6 RID: 3062
		private static readonly IntPtr NativeMethodInfoPtr_AnimateOpen_Public_Virtual_IEnumerator_0;

		// Token: 0x04000BF7 RID: 3063
		private static readonly IntPtr NativeMethodInfoPtr_sceneLoaded_Private_Boolean_String_0;

		// Token: 0x04000BF8 RID: 3064
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BF9 RID: 3065
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerator_0;

		// Token: 0x020003A7 RID: 935
		[ObfuscatedName("boardgames.menus.ui.LandingPromptAnims+<AnimateOpen>d__1")]
		public sealed class _AnimateOpen_d__1 : Object
		{
			// Token: 0x06002BDA RID: 11226 RVA: 0x000ABA68 File Offset: 0x000A9C68
			// Note: this type is marked as 'beforefieldinit'.
			static _AnimateOpen_d__1()
			{
				Il2CppClassPointerStore<LandingPromptAnims._AnimateOpen_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LandingPromptAnims>.NativeClassPtr, "<AnimateOpen>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandingPromptAnims._AnimateOpen_d__1>.NativeClassPtr);
				LandingPromptAnims._AnimateOpen_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingPromptAnims._AnimateOpen_d__1>.NativeClassPtr, "<>1__state");
				LandingPromptAnims._AnimateOpen_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingPromptAnims._AnimateOpen_d__1>.NativeClassPtr, "<>2__current");
				LandingPromptAnims._AnimateOpen_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingPromptAnims._AnimateOpen_d__1>.NativeClassPtr, "<>4__this");
				LandingPromptAnims._AnimateOpen_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingPromptAnims._AnimateOpen_d__1>.NativeClassPtr, 100666167);
				LandingPromptAnims._AnimateOpen_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingPromptAnims._AnimateOpen_d__1>.NativeClassPtr, 100666168);
				LandingPromptAnims._AnimateOpen_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingPromptAnims._AnimateOpen_d__1>.NativeClassPtr, 100666169);
				LandingPromptAnims._AnimateOpen_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingPromptAnims._AnimateOpen_d__1>.NativeClassPtr, 100666170);
				LandingPromptAnims._AnimateOpen_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingPromptAnims._AnimateOpen_d__1>.NativeClassPtr, 100666171);
				LandingPromptAnims._AnimateOpen_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingPromptAnims._AnimateOpen_d__1>.NativeClassPtr, 100666172);
			}

			// Token: 0x06002BDB RID: 11227 RVA: 0x000ABB48 File Offset: 0x000A9D48
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AnimateOpen_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandingPromptAnims._AnimateOpen_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingPromptAnims._AnimateOpen_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002BDC RID: 11228 RVA: 0x000ABB90 File Offset: 0x000A9D90
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingPromptAnims._AnimateOpen_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002BDD RID: 11229 RVA: 0x000ABBC4 File Offset: 0x000A9DC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519338, XrefRangeEnd = 519351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingPromptAnims._AnimateOpen_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C73 RID: 3187
			// (get) Token: 0x06002BDE RID: 11230 RVA: 0x000ABC00 File Offset: 0x000A9E00
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingPromptAnims._AnimateOpen_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002BDF RID: 11231 RVA: 0x000ABC40 File Offset: 0x000A9E40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519351, XrefRangeEnd = 519356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingPromptAnims._AnimateOpen_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C74 RID: 3188
			// (get) Token: 0x06002BE0 RID: 11232 RVA: 0x000ABC74 File Offset: 0x000A9E74
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingPromptAnims._AnimateOpen_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002BE1 RID: 11233 RVA: 0x00016B04 File Offset: 0x00014D04
			public _AnimateOpen_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C70 RID: 3184
			// (get) Token: 0x06002BE2 RID: 11234 RVA: 0x000ABCB4 File Offset: 0x000A9EB4
			// (set) Token: 0x06002BE3 RID: 11235 RVA: 0x00016B0D File Offset: 0x00014D0D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingPromptAnims._AnimateOpen_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingPromptAnims._AnimateOpen_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C71 RID: 3185
			// (get) Token: 0x06002BE4 RID: 11236 RVA: 0x000ABCDC File Offset: 0x000A9EDC
			// (set) Token: 0x06002BE5 RID: 11237 RVA: 0x00016B28 File Offset: 0x00014D28
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingPromptAnims._AnimateOpen_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingPromptAnims._AnimateOpen_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C72 RID: 3186
			// (get) Token: 0x06002BE6 RID: 11238 RVA: 0x000ABD0C File Offset: 0x000A9F0C
			// (set) Token: 0x06002BE7 RID: 11239 RVA: 0x00016B47 File Offset: 0x00014D47
			public unsafe LandingPromptAnims __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingPromptAnims._AnimateOpen_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandingPromptAnims>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingPromptAnims._AnimateOpen_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B4E RID: 6990
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001B4F RID: 6991
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001B50 RID: 6992
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001B51 RID: 6993
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001B52 RID: 6994
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B53 RID: 6995
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001B54 RID: 6996
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001B55 RID: 6997
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B56 RID: 6998
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
