using System;
using boardgames.camera;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;

namespace dbgclient.sequences
{
	// Token: 0x0200008E RID: 142
	public class DBGGameStartSequence : VoodooGenericSequence
	{
		// Token: 0x0600058D RID: 1421 RVA: 0x0002F274 File Offset: 0x0002D474
		// Note: this type is marked as 'beforefieldinit'.
		static DBGGameStartSequence()
		{
			Il2CppClassPointerStore<DBGGameStartSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.sequences", "DBGGameStartSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGGameStartSequence>.NativeClassPtr);
			DBGGameStartSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGGameStartSequence>.NativeClassPtr, 100664139);
			DBGGameStartSequence.NativeMethodInfoPtr_executeSequence_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGGameStartSequence>.NativeClassPtr, 100664140);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x0002F2CC File Offset: 0x0002D4CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGGameStartSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGGameStartSequence>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGGameStartSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x0002F33C File Offset: 0x0002D53C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501949, XrefRangeEnd = 501953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator executeSequence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGGameStartSequence.NativeMethodInfoPtr_executeSequence_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x000047E7 File Offset: 0x000029E7
		public DBGGameStartSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeMethodInfoPtr_executeSequence_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000302 RID: 770
		[ObfuscatedName("dbgclient.sequences.DBGGameStartSequence+<executeSequence>d__1")]
		public sealed class _executeSequence_d__1 : Object
		{
			// Token: 0x06002461 RID: 9313 RVA: 0x000953F0 File Offset: 0x000935F0
			// Note: this type is marked as 'beforefieldinit'.
			static _executeSequence_d__1()
			{
				Il2CppClassPointerStore<DBGGameStartSequence._executeSequence_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGGameStartSequence>.NativeClassPtr, "<executeSequence>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGGameStartSequence._executeSequence_d__1>.NativeClassPtr);
				DBGGameStartSequence._executeSequence_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGGameStartSequence._executeSequence_d__1>.NativeClassPtr, "<>1__state");
				DBGGameStartSequence._executeSequence_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGGameStartSequence._executeSequence_d__1>.NativeClassPtr, "<>2__current");
				DBGGameStartSequence._executeSequence_d__1.NativeFieldInfoPtr__cameraLocationManager_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGGameStartSequence._executeSequence_d__1>.NativeClassPtr, "<cameraLocationManager>5__2");
				DBGGameStartSequence._executeSequence_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGGameStartSequence._executeSequence_d__1>.NativeClassPtr, 100664141);
				DBGGameStartSequence._executeSequence_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGGameStartSequence._executeSequence_d__1>.NativeClassPtr, 100664142);
				DBGGameStartSequence._executeSequence_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGGameStartSequence._executeSequence_d__1>.NativeClassPtr, 100664143);
				DBGGameStartSequence._executeSequence_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGGameStartSequence._executeSequence_d__1>.NativeClassPtr, 100664144);
				DBGGameStartSequence._executeSequence_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGGameStartSequence._executeSequence_d__1>.NativeClassPtr, 100664145);
				DBGGameStartSequence._executeSequence_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGGameStartSequence._executeSequence_d__1>.NativeClassPtr, 100664146);
			}

			// Token: 0x06002462 RID: 9314 RVA: 0x000954D0 File Offset: 0x000936D0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _executeSequence_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGGameStartSequence._executeSequence_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGGameStartSequence._executeSequence_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002463 RID: 9315 RVA: 0x00095518 File Offset: 0x00093718
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGGameStartSequence._executeSequence_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002464 RID: 9316 RVA: 0x0009554C File Offset: 0x0009374C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501943, XrefRangeEnd = 501944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGGameStartSequence._executeSequence_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170009F5 RID: 2549
			// (get) Token: 0x06002465 RID: 9317 RVA: 0x00095588 File Offset: 0x00093788
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGGameStartSequence._executeSequence_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002466 RID: 9318 RVA: 0x000955C8 File Offset: 0x000937C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501944, XrefRangeEnd = 501949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGGameStartSequence._executeSequence_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009F6 RID: 2550
			// (get) Token: 0x06002467 RID: 9319 RVA: 0x000955FC File Offset: 0x000937FC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGGameStartSequence._executeSequence_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002468 RID: 9320 RVA: 0x00012EFA File Offset: 0x000110FA
			public _executeSequence_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009F2 RID: 2546
			// (get) Token: 0x06002469 RID: 9321 RVA: 0x0009563C File Offset: 0x0009383C
			// (set) Token: 0x0600246A RID: 9322 RVA: 0x00012F03 File Offset: 0x00011103
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGGameStartSequence._executeSequence_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGGameStartSequence._executeSequence_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009F3 RID: 2547
			// (get) Token: 0x0600246B RID: 9323 RVA: 0x00095664 File Offset: 0x00093864
			// (set) Token: 0x0600246C RID: 9324 RVA: 0x00012F1E File Offset: 0x0001111E
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGGameStartSequence._executeSequence_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGGameStartSequence._executeSequence_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009F4 RID: 2548
			// (get) Token: 0x0600246D RID: 9325 RVA: 0x00095694 File Offset: 0x00093894
			// (set) Token: 0x0600246E RID: 9326 RVA: 0x00012F3D File Offset: 0x0001113D
			public unsafe CameraLocationManager _cameraLocationManager_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGGameStartSequence._executeSequence_d__1.NativeFieldInfoPtr__cameraLocationManager_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraLocationManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGGameStartSequence._executeSequence_d__1.NativeFieldInfoPtr__cameraLocationManager_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016DA RID: 5850
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016DB RID: 5851
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040016DC RID: 5852
			private static readonly IntPtr NativeFieldInfoPtr__cameraLocationManager_5__2;

			// Token: 0x040016DD RID: 5853
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040016DE RID: 5854
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016DF RID: 5855
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040016E0 RID: 5856
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040016E1 RID: 5857
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016E2 RID: 5858
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
