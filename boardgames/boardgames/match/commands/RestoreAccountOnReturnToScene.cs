using System;
using dwd.core.account;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.SceneManagement;

namespace boardgames.match.commands
{
	// Token: 0x02000130 RID: 304
	public sealed class RestoreAccountOnReturnToScene : Command
	{
		// Token: 0x06000FEB RID: 4075 RVA: 0x00041C84 File Offset: 0x0003FE84
		// Note: this type is marked as 'beforefieldinit'.
		static RestoreAccountOnReturnToScene()
		{
			Il2CppClassPointerStore<RestoreAccountOnReturnToScene>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.match.commands", "RestoreAccountOnReturnToScene");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RestoreAccountOnReturnToScene>.NativeClassPtr);
			RestoreAccountOnReturnToScene.NativeFieldInfoPtr_requiredLoadedScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestoreAccountOnReturnToScene>.NativeClassPtr, "requiredLoadedScene");
			RestoreAccountOnReturnToScene.NativeFieldInfoPtr_isMatchComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestoreAccountOnReturnToScene>.NativeClassPtr, "isMatchComplete");
			RestoreAccountOnReturnToScene.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestoreAccountOnReturnToScene>.NativeClassPtr, 100665584);
			RestoreAccountOnReturnToScene.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestoreAccountOnReturnToScene>.NativeClassPtr, 100665585);
			RestoreAccountOnReturnToScene.NativeMethodInfoPtr_onSceneLoaded_Private_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestoreAccountOnReturnToScene>.NativeClassPtr, 100665586);
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x00041D18 File Offset: 0x0003FF18
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RestoreAccountOnReturnToScene(string requiredLoadedScene)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RestoreAccountOnReturnToScene>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(requiredLoadedScene);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RestoreAccountOnReturnToScene.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x00041D64 File Offset: 0x0003FF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998403, XrefRangeEnd = 998408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RestoreAccountOnReturnToScene.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x00041DA4 File Offset: 0x0003FFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998408, XrefRangeEnd = 998420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onSceneLoaded(Scene scene, LoadSceneMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RestoreAccountOnReturnToScene.NativeMethodInfoPtr_onSceneLoaded_Private_Void_Scene_LoadSceneMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00009619 File Offset: 0x00007819
		public RestoreAccountOnReturnToScene(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x00041DF0 File Offset: 0x0003FFF0
		// (set) Token: 0x06000FF1 RID: 4081 RVA: 0x00009622 File Offset: 0x00007822
		public unsafe string requiredLoadedScene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestoreAccountOnReturnToScene.NativeFieldInfoPtr_requiredLoadedScene);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestoreAccountOnReturnToScene.NativeFieldInfoPtr_requiredLoadedScene), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x00041E18 File Offset: 0x00040018
		// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x00009641 File Offset: 0x00007841
		public unsafe bool isMatchComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestoreAccountOnReturnToScene.NativeFieldInfoPtr_isMatchComplete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestoreAccountOnReturnToScene.NativeFieldInfoPtr_isMatchComplete)) = value;
			}
		}

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeFieldInfoPtr_requiredLoadedScene;

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeFieldInfoPtr_isMatchComplete;

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeMethodInfoPtr_onSceneLoaded_Private_Void_Scene_LoadSceneMode_0;

		// Token: 0x02000267 RID: 615
		[ObfuscatedName("boardgames.match.commands.RestoreAccountOnReturnToScene+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x06001C2E RID: 7214 RVA: 0x00067F78 File Offset: 0x00066178
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<RestoreAccountOnReturnToScene._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RestoreAccountOnReturnToScene>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RestoreAccountOnReturnToScene._execute_d__3>.NativeClassPtr);
				RestoreAccountOnReturnToScene._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestoreAccountOnReturnToScene._execute_d__3>.NativeClassPtr, "<>1__state");
				RestoreAccountOnReturnToScene._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestoreAccountOnReturnToScene._execute_d__3>.NativeClassPtr, "<>2__current");
				RestoreAccountOnReturnToScene._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestoreAccountOnReturnToScene._execute_d__3>.NativeClassPtr, "<>4__this");
				RestoreAccountOnReturnToScene._execute_d__3.NativeFieldInfoPtr__accountProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestoreAccountOnReturnToScene._execute_d__3>.NativeClassPtr, "<accountProvider>5__2");
				RestoreAccountOnReturnToScene._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestoreAccountOnReturnToScene._execute_d__3>.NativeClassPtr, 100665587);
				RestoreAccountOnReturnToScene._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestoreAccountOnReturnToScene._execute_d__3>.NativeClassPtr, 100665588);
				RestoreAccountOnReturnToScene._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestoreAccountOnReturnToScene._execute_d__3>.NativeClassPtr, 100665589);
				RestoreAccountOnReturnToScene._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestoreAccountOnReturnToScene._execute_d__3>.NativeClassPtr, 100665590);
				RestoreAccountOnReturnToScene._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestoreAccountOnReturnToScene._execute_d__3>.NativeClassPtr, 100665591);
				RestoreAccountOnReturnToScene._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestoreAccountOnReturnToScene._execute_d__3>.NativeClassPtr, 100665592);
			}

			// Token: 0x06001C2F RID: 7215 RVA: 0x0006806C File Offset: 0x0006626C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RestoreAccountOnReturnToScene._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RestoreAccountOnReturnToScene._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C30 RID: 7216 RVA: 0x000680B4 File Offset: 0x000662B4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RestoreAccountOnReturnToScene._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C31 RID: 7217 RVA: 0x000680E8 File Offset: 0x000662E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998360, XrefRangeEnd = 998398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RestoreAccountOnReturnToScene._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000858 RID: 2136
			// (get) Token: 0x06001C32 RID: 7218 RVA: 0x00068124 File Offset: 0x00066324
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RestoreAccountOnReturnToScene._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C33 RID: 7219 RVA: 0x00068164 File Offset: 0x00066364
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998398, XrefRangeEnd = 998403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RestoreAccountOnReturnToScene._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000859 RID: 2137
			// (get) Token: 0x06001C34 RID: 7220 RVA: 0x00068198 File Offset: 0x00066398
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RestoreAccountOnReturnToScene._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C35 RID: 7221 RVA: 0x0000F371 File Offset: 0x0000D571
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000854 RID: 2132
			// (get) Token: 0x06001C36 RID: 7222 RVA: 0x000681D8 File Offset: 0x000663D8
			// (set) Token: 0x06001C37 RID: 7223 RVA: 0x0000F37A File Offset: 0x0000D57A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestoreAccountOnReturnToScene._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestoreAccountOnReturnToScene._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000855 RID: 2133
			// (get) Token: 0x06001C38 RID: 7224 RVA: 0x00068200 File Offset: 0x00066400
			// (set) Token: 0x06001C39 RID: 7225 RVA: 0x0000F395 File Offset: 0x0000D595
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestoreAccountOnReturnToScene._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestoreAccountOnReturnToScene._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000856 RID: 2134
			// (get) Token: 0x06001C3A RID: 7226 RVA: 0x00068230 File Offset: 0x00066430
			// (set) Token: 0x06001C3B RID: 7227 RVA: 0x0000F3B4 File Offset: 0x0000D5B4
			public unsafe RestoreAccountOnReturnToScene __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestoreAccountOnReturnToScene._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RestoreAccountOnReturnToScene>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestoreAccountOnReturnToScene._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000857 RID: 2135
			// (get) Token: 0x06001C3C RID: 7228 RVA: 0x00068260 File Offset: 0x00066460
			// (set) Token: 0x06001C3D RID: 7229 RVA: 0x0000F3D3 File Offset: 0x0000D5D3
			public unsafe AccountProvider _accountProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestoreAccountOnReturnToScene._execute_d__3.NativeFieldInfoPtr__accountProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestoreAccountOnReturnToScene._execute_d__3.NativeFieldInfoPtr__accountProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001121 RID: 4385
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001122 RID: 4386
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001123 RID: 4387
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001124 RID: 4388
			private static readonly IntPtr NativeFieldInfoPtr__accountProvider_5__2;

			// Token: 0x04001125 RID: 4389
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001126 RID: 4390
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001127 RID: 4391
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001128 RID: 4392
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001129 RID: 4393
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400112A RID: 4394
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
