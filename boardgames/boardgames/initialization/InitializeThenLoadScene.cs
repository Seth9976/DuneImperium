using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace boardgames.initialization
{
	// Token: 0x02000136 RID: 310
	public class InitializeThenLoadScene : MonoBehaviour
	{
		// Token: 0x06001034 RID: 4148 RVA: 0x00042B68 File Offset: 0x00040D68
		// Note: this type is marked as 'beforefieldinit'.
		static InitializeThenLoadScene()
		{
			Il2CppClassPointerStore<InitializeThenLoadScene>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.initialization", "InitializeThenLoadScene");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeThenLoadScene>.NativeClassPtr);
			InitializeThenLoadScene.NativeFieldInfoPtr_sceneReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThenLoadScene>.NativeClassPtr, "sceneReference");
			InitializeThenLoadScene.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThenLoadScene>.NativeClassPtr, 100665654);
			InitializeThenLoadScene.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThenLoadScene>.NativeClassPtr, 100665655);
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x00042BD4 File Offset: 0x00040DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998991, XrefRangeEnd = 998996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeThenLoadScene.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x00042C14 File Offset: 0x00040E14
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InitializeThenLoadScene()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializeThenLoadScene>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeThenLoadScene.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x00009885 File Offset: 0x00007A85
		public InitializeThenLoadScene(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x00042C50 File Offset: 0x00040E50
		// (set) Token: 0x06001039 RID: 4153 RVA: 0x0000988E File Offset: 0x00007A8E
		public unsafe AssetReference sceneReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeThenLoadScene.NativeFieldInfoPtr_sceneReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeThenLoadScene.NativeFieldInfoPtr_sceneReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeFieldInfoPtr_sceneReference;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200026D RID: 621
		[ObfuscatedName("boardgames.initialization.InitializeThenLoadScene+<Start>d__1")]
		public sealed class _Start_d__1 : global::Il2CppSystem.Object
		{
			// Token: 0x06001C8F RID: 7311 RVA: 0x000692F8 File Offset: 0x000674F8
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__1()
			{
				Il2CppClassPointerStore<InitializeThenLoadScene._Start_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitializeThenLoadScene>.NativeClassPtr, "<Start>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeThenLoadScene._Start_d__1>.NativeClassPtr);
				InitializeThenLoadScene._Start_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThenLoadScene._Start_d__1>.NativeClassPtr, "<>1__state");
				InitializeThenLoadScene._Start_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThenLoadScene._Start_d__1>.NativeClassPtr, "<>2__current");
				InitializeThenLoadScene._Start_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThenLoadScene._Start_d__1>.NativeClassPtr, "<>4__this");
				InitializeThenLoadScene._Start_d__1.NativeFieldInfoPtr__initCommands_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThenLoadScene._Start_d__1>.NativeClassPtr, "<initCommands>5__2");
				InitializeThenLoadScene._Start_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThenLoadScene._Start_d__1>.NativeClassPtr, 100665656);
				InitializeThenLoadScene._Start_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThenLoadScene._Start_d__1>.NativeClassPtr, 100665657);
				InitializeThenLoadScene._Start_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThenLoadScene._Start_d__1>.NativeClassPtr, 100665658);
				InitializeThenLoadScene._Start_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThenLoadScene._Start_d__1>.NativeClassPtr, 100665659);
				InitializeThenLoadScene._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThenLoadScene._Start_d__1>.NativeClassPtr, 100665660);
				InitializeThenLoadScene._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThenLoadScene._Start_d__1>.NativeClassPtr, 100665661);
			}

			// Token: 0x06001C90 RID: 7312 RVA: 0x000693EC File Offset: 0x000675EC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializeThenLoadScene._Start_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeThenLoadScene._Start_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C91 RID: 7313 RVA: 0x00069434 File Offset: 0x00067634
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeThenLoadScene._Start_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C92 RID: 7314 RVA: 0x00069468 File Offset: 0x00067668
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998954, XrefRangeEnd = 998986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeThenLoadScene._Start_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000879 RID: 2169
			// (get) Token: 0x06001C93 RID: 7315 RVA: 0x000694A4 File Offset: 0x000676A4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeThenLoadScene._Start_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C94 RID: 7316 RVA: 0x000694E4 File Offset: 0x000676E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998986, XrefRangeEnd = 998991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeThenLoadScene._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700087A RID: 2170
			// (get) Token: 0x06001C95 RID: 7317 RVA: 0x00069518 File Offset: 0x00067718
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeThenLoadScene._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C96 RID: 7318 RVA: 0x0000F61B File Offset: 0x0000D81B
			public _Start_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000875 RID: 2165
			// (get) Token: 0x06001C97 RID: 7319 RVA: 0x00069558 File Offset: 0x00067758
			// (set) Token: 0x06001C98 RID: 7320 RVA: 0x0000F624 File Offset: 0x0000D824
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeThenLoadScene._Start_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeThenLoadScene._Start_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000876 RID: 2166
			// (get) Token: 0x06001C99 RID: 7321 RVA: 0x00069580 File Offset: 0x00067780
			// (set) Token: 0x06001C9A RID: 7322 RVA: 0x0000F63F File Offset: 0x0000D83F
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeThenLoadScene._Start_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeThenLoadScene._Start_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000877 RID: 2167
			// (get) Token: 0x06001C9B RID: 7323 RVA: 0x000695B0 File Offset: 0x000677B0
			// (set) Token: 0x06001C9C RID: 7324 RVA: 0x0000F65E File Offset: 0x0000D85E
			public unsafe InitializeThenLoadScene __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeThenLoadScene._Start_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InitializeThenLoadScene>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeThenLoadScene._Start_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000878 RID: 2168
			// (get) Token: 0x06001C9D RID: 7325 RVA: 0x000695E0 File Offset: 0x000677E0
			// (set) Token: 0x06001C9E RID: 7326 RVA: 0x0000F67D File Offset: 0x0000D87D
			public unsafe IEnumerator _initCommands_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeThenLoadScene._Start_d__1.NativeFieldInfoPtr__initCommands_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeThenLoadScene._Start_d__1.NativeFieldInfoPtr__initCommands_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400115F RID: 4447
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001160 RID: 4448
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001161 RID: 4449
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001162 RID: 4450
			private static readonly IntPtr NativeFieldInfoPtr__initCommands_5__2;

			// Token: 0x04001163 RID: 4451
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001164 RID: 4452
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001165 RID: 4453
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001166 RID: 4454
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001167 RID: 4455
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001168 RID: 4456
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
