using System;
using Canis.utils.ids;
using dwd.core;
using dwd.core.commands;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Networking;

namespace boardgames.menus.commands
{
	// Token: 0x02000210 RID: 528
	public class ResignCasualGame : Command
	{
		// Token: 0x06001843 RID: 6211 RVA: 0x0006C5A0 File Offset: 0x0006A7A0
		// Note: this type is marked as 'beforefieldinit'.
		static ResignCasualGame()
		{
			Il2CppClassPointerStore<ResignCasualGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "ResignCasualGame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResignCasualGame>.NativeClassPtr);
			ResignCasualGame.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResignCasualGame>.NativeClassPtr, "gameID");
			ResignCasualGame.NativeFieldInfoPtr_notifyOnFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResignCasualGame>.NativeClassPtr, "notifyOnFailure");
			ResignCasualGame.NativeFieldInfoPtr_resign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResignCasualGame>.NativeClassPtr, "resign");
			ResignCasualGame.NativeMethodInfoPtr__ctor_Public_Void_GameID_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResignCasualGame>.NativeClassPtr, 100666872);
			ResignCasualGame.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResignCasualGame>.NativeClassPtr, 100666873);
			ResignCasualGame.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResignCasualGame>.NativeClassPtr, 100666874);
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x0006C648 File Offset: 0x0006A848
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 505858, RefRangeEnd = 505863, XrefRangeStart = 505858, XrefRangeEnd = 505863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResignCasualGame(GameID gameID, bool notifyOnFailure = true)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResignCasualGame>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notifyOnFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResignCasualGame.NativeMethodInfoPtr__ctor_Public_Void_GameID_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x0006C6A4 File Offset: 0x0006A8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526636, XrefRangeEnd = 526641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResignCasualGame.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x0006C6F0 File Offset: 0x0006A8F0
		[CallerCount(0)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResignCasualGame.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x0000D700 File Offset: 0x0000B900
		public ResignCasualGame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001848 RID: 6216 RVA: 0x0006C728 File Offset: 0x0006A928
		// (set) Token: 0x06001849 RID: 6217 RVA: 0x0000D709 File Offset: 0x0000B909
		public unsafe GameID gameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResignCasualGame.NativeFieldInfoPtr_gameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResignCasualGame.NativeFieldInfoPtr_gameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x0600184A RID: 6218 RVA: 0x0006C758 File Offset: 0x0006A958
		// (set) Token: 0x0600184B RID: 6219 RVA: 0x0000D728 File Offset: 0x0000B928
		public unsafe bool notifyOnFailure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResignCasualGame.NativeFieldInfoPtr_notifyOnFailure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResignCasualGame.NativeFieldInfoPtr_notifyOnFailure)) = value;
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x0600184C RID: 6220 RVA: 0x0006C780 File Offset: 0x0006A980
		// (set) Token: 0x0600184D RID: 6221 RVA: 0x0000D743 File Offset: 0x0000B943
		public unsafe DwdWebRequestCommand resign
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResignCasualGame.NativeFieldInfoPtr_resign);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DwdWebRequestCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResignCasualGame.NativeFieldInfoPtr_resign), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F32 RID: 3890
		private static readonly IntPtr NativeFieldInfoPtr_gameID;

		// Token: 0x04000F33 RID: 3891
		private static readonly IntPtr NativeFieldInfoPtr_notifyOnFailure;

		// Token: 0x04000F34 RID: 3892
		private static readonly IntPtr NativeFieldInfoPtr_resign;

		// Token: 0x04000F35 RID: 3893
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameID_Boolean_0;

		// Token: 0x04000F36 RID: 3894
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000F37 RID: 3895
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x020003E2 RID: 994
		[ObfuscatedName("boardgames.menus.commands.ResignCasualGame+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002E4A RID: 11850 RVA: 0x000B2BE4 File Offset: 0x000B0DE4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ResignCasualGame.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResignCasualGame>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResignCasualGame.__c>.NativeClassPtr);
				ResignCasualGame.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResignCasualGame.__c>.NativeClassPtr, "<>9");
				ResignCasualGame.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResignCasualGame.__c>.NativeClassPtr, "<>9__4_0");
				ResignCasualGame.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResignCasualGame.__c>.NativeClassPtr, 100666876);
				ResignCasualGame.__c.NativeMethodInfoPtr__execute_b__4_0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResignCasualGame.__c>.NativeClassPtr, 100666877);
			}

			// Token: 0x06002E4B RID: 11851 RVA: 0x000B2C60 File Offset: 0x000B0E60
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResignCasualGame.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResignCasualGame.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E4C RID: 11852 RVA: 0x000B2C9C File Offset: 0x000B0E9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526597, XrefRangeEnd = 526605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__4_0(UnityWebRequest request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResignCasualGame.__c.NativeMethodInfoPtr__execute_b__4_0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002E4D RID: 11853 RVA: 0x00017EA9 File Offset: 0x000160A9
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D2F RID: 3375
			// (get) Token: 0x06002E4E RID: 11854 RVA: 0x000B2CE0 File Offset: 0x000B0EE0
			// (set) Token: 0x06002E4F RID: 11855 RVA: 0x00017EB2 File Offset: 0x000160B2
			public unsafe static ResignCasualGame.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResignCasualGame.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResignCasualGame.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResignCasualGame.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D30 RID: 3376
			// (get) Token: 0x06002E50 RID: 11856 RVA: 0x000B2D08 File Offset: 0x000B0F08
			// (set) Token: 0x06002E51 RID: 11857 RVA: 0x00017EC4 File Offset: 0x000160C4
			public unsafe static Action<UnityWebRequest> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResignCasualGame.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResignCasualGame.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001CAB RID: 7339
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001CAC RID: 7340
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04001CAD RID: 7341
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001CAE RID: 7342
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__4_0_Internal_Void_UnityWebRequest_0;
		}

		// Token: 0x020003E3 RID: 995
		[ObfuscatedName("boardgames.menus.commands.ResignCasualGame+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x06002E52 RID: 11858 RVA: 0x000B2D30 File Offset: 0x000B0F30
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<ResignCasualGame._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResignCasualGame>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResignCasualGame._execute_d__4>.NativeClassPtr);
				ResignCasualGame._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResignCasualGame._execute_d__4>.NativeClassPtr, "<>1__state");
				ResignCasualGame._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResignCasualGame._execute_d__4>.NativeClassPtr, "<>2__current");
				ResignCasualGame._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResignCasualGame._execute_d__4>.NativeClassPtr, "<>4__this");
				ResignCasualGame._execute_d__4.NativeFieldInfoPtr__url_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResignCasualGame._execute_d__4>.NativeClassPtr, "<url>5__2");
				ResignCasualGame._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResignCasualGame._execute_d__4>.NativeClassPtr, 100666878);
				ResignCasualGame._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResignCasualGame._execute_d__4>.NativeClassPtr, 100666879);
				ResignCasualGame._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResignCasualGame._execute_d__4>.NativeClassPtr, 100666880);
				ResignCasualGame._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResignCasualGame._execute_d__4>.NativeClassPtr, 100666881);
				ResignCasualGame._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResignCasualGame._execute_d__4>.NativeClassPtr, 100666882);
				ResignCasualGame._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResignCasualGame._execute_d__4>.NativeClassPtr, 100666883);
			}

			// Token: 0x06002E53 RID: 11859 RVA: 0x000B2E24 File Offset: 0x000B1024
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResignCasualGame._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResignCasualGame._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002E54 RID: 11860 RVA: 0x000B2E6C File Offset: 0x000B106C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResignCasualGame._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E55 RID: 11861 RVA: 0x000B2EA0 File Offset: 0x000B10A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526605, XrefRangeEnd = 526631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResignCasualGame._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D35 RID: 3381
			// (get) Token: 0x06002E56 RID: 11862 RVA: 0x000B2EDC File Offset: 0x000B10DC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResignCasualGame._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002E57 RID: 11863 RVA: 0x000B2F1C File Offset: 0x000B111C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526631, XrefRangeEnd = 526636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResignCasualGame._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D36 RID: 3382
			// (get) Token: 0x06002E58 RID: 11864 RVA: 0x000B2F50 File Offset: 0x000B1150
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResignCasualGame._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002E59 RID: 11865 RVA: 0x00017ED6 File Offset: 0x000160D6
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D31 RID: 3377
			// (get) Token: 0x06002E5A RID: 11866 RVA: 0x000B2F90 File Offset: 0x000B1190
			// (set) Token: 0x06002E5B RID: 11867 RVA: 0x00017EDF File Offset: 0x000160DF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResignCasualGame._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResignCasualGame._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D32 RID: 3378
			// (get) Token: 0x06002E5C RID: 11868 RVA: 0x000B2FB8 File Offset: 0x000B11B8
			// (set) Token: 0x06002E5D RID: 11869 RVA: 0x00017EFA File Offset: 0x000160FA
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResignCasualGame._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResignCasualGame._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D33 RID: 3379
			// (get) Token: 0x06002E5E RID: 11870 RVA: 0x000B2FE8 File Offset: 0x000B11E8
			// (set) Token: 0x06002E5F RID: 11871 RVA: 0x00017F19 File Offset: 0x00016119
			public unsafe ResignCasualGame __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResignCasualGame._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResignCasualGame>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResignCasualGame._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D34 RID: 3380
			// (get) Token: 0x06002E60 RID: 11872 RVA: 0x000B3018 File Offset: 0x000B1218
			// (set) Token: 0x06002E61 RID: 11873 RVA: 0x00017F38 File Offset: 0x00016138
			public unsafe string _url_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResignCasualGame._execute_d__4.NativeFieldInfoPtr__url_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResignCasualGame._execute_d__4.NativeFieldInfoPtr__url_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001CAF RID: 7343
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001CB0 RID: 7344
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001CB1 RID: 7345
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001CB2 RID: 7346
			private static readonly IntPtr NativeFieldInfoPtr__url_5__2;

			// Token: 0x04001CB3 RID: 7347
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001CB4 RID: 7348
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CB5 RID: 7349
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001CB6 RID: 7350
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001CB7 RID: 7351
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CB8 RID: 7352
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
