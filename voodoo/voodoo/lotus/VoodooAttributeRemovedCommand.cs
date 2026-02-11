using System;
using Canis.attributes;
using Canis.messages;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace lotus
{
	// Token: 0x02000060 RID: 96
	public class VoodooAttributeRemovedCommand : Command
	{
		// Token: 0x0600058B RID: 1419 RVA: 0x0001BBCC File Offset: 0x00019DCC
		// Note: this type is marked as 'beforefieldinit'.
		static VoodooAttributeRemovedCommand()
		{
			Il2CppClassPointerStore<VoodooAttributeRemovedCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "VoodooAttributeRemovedCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooAttributeRemovedCommand>.NativeClassPtr);
			VoodooAttributeRemovedCommand.NativeFieldInfoPtr_AttributeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooAttributeRemovedCommand>.NativeClassPtr, "AttributeKey");
			VoodooAttributeRemovedCommand.NativeFieldInfoPtr_EntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooAttributeRemovedCommand>.NativeClassPtr, "EntityID");
			VoodooAttributeRemovedCommand.NativeMethodInfoPtr__ctor_Public_Void_AttributeRemoved_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooAttributeRemovedCommand>.NativeClassPtr, 100664049);
			VoodooAttributeRemovedCommand.NativeMethodInfoPtr__ctor_Public_Void_EntityID_IAttributeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooAttributeRemovedCommand>.NativeClassPtr, 100664050);
			VoodooAttributeRemovedCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooAttributeRemovedCommand>.NativeClassPtr, 100664051);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x0001BC60 File Offset: 0x00019E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111853, XrefRangeEnd = 1111855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoodooAttributeRemovedCommand(AttributeRemoved message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooAttributeRemovedCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooAttributeRemovedCommand.NativeMethodInfoPtr__ctor_Public_Void_AttributeRemoved_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0001BCAC File Offset: 0x00019EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111855, XrefRangeEnd = 1111860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoodooAttributeRemovedCommand(EntityID entityID, IAttributeDefinition attributeDef)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooAttributeRemovedCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeDef);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooAttributeRemovedCommand.NativeMethodInfoPtr__ctor_Public_Void_EntityID_IAttributeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x0001BD0C File Offset: 0x00019F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111860, XrefRangeEnd = 1111865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooAttributeRemovedCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00004B4C File Offset: 0x00002D4C
		public VoodooAttributeRemovedCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x0001BD58 File Offset: 0x00019F58
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x00004B55 File Offset: 0x00002D55
		public unsafe int AttributeKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooAttributeRemovedCommand.NativeFieldInfoPtr_AttributeKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooAttributeRemovedCommand.NativeFieldInfoPtr_AttributeKey)) = value;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x0001BD80 File Offset: 0x00019F80
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x00004B70 File Offset: 0x00002D70
		public unsafe EntityID EntityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooAttributeRemovedCommand.NativeFieldInfoPtr_EntityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooAttributeRemovedCommand.NativeFieldInfoPtr_EntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeFieldInfoPtr_AttributeKey;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeFieldInfoPtr_EntityID;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeRemoved_0;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityID_IAttributeDefinition_0;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x020000E3 RID: 227
		[ObfuscatedName("lotus.VoodooAttributeRemovedCommand+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x06000BEF RID: 3055 RVA: 0x000304A0 File Offset: 0x0002E6A0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<VoodooAttributeRemovedCommand._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooAttributeRemovedCommand>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooAttributeRemovedCommand._execute_d__4>.NativeClassPtr);
				VoodooAttributeRemovedCommand._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooAttributeRemovedCommand._execute_d__4>.NativeClassPtr, "<>1__state");
				VoodooAttributeRemovedCommand._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooAttributeRemovedCommand._execute_d__4>.NativeClassPtr, "<>2__current");
				VoodooAttributeRemovedCommand._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooAttributeRemovedCommand._execute_d__4>.NativeClassPtr, "<>4__this");
				VoodooAttributeRemovedCommand._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooAttributeRemovedCommand._execute_d__4>.NativeClassPtr, 100664052);
				VoodooAttributeRemovedCommand._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooAttributeRemovedCommand._execute_d__4>.NativeClassPtr, 100664053);
				VoodooAttributeRemovedCommand._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooAttributeRemovedCommand._execute_d__4>.NativeClassPtr, 100664054);
				VoodooAttributeRemovedCommand._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooAttributeRemovedCommand._execute_d__4>.NativeClassPtr, 100664055);
				VoodooAttributeRemovedCommand._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooAttributeRemovedCommand._execute_d__4>.NativeClassPtr, 100664056);
				VoodooAttributeRemovedCommand._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooAttributeRemovedCommand._execute_d__4>.NativeClassPtr, 100664057);
			}

			// Token: 0x06000BF0 RID: 3056 RVA: 0x00030580 File Offset: 0x0002E780
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooAttributeRemovedCommand._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooAttributeRemovedCommand._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000BF1 RID: 3057 RVA: 0x000305C8 File Offset: 0x0002E7C8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooAttributeRemovedCommand._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000BF2 RID: 3058 RVA: 0x000305FC File Offset: 0x0002E7FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111839, XrefRangeEnd = 1111848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooAttributeRemovedCommand._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000388 RID: 904
			// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x00030638 File Offset: 0x0002E838
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooAttributeRemovedCommand._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000BF4 RID: 3060 RVA: 0x00030678 File Offset: 0x0002E878
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111848, XrefRangeEnd = 1111853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooAttributeRemovedCommand._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000389 RID: 905
			// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x000306AC File Offset: 0x0002E8AC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooAttributeRemovedCommand._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000BF6 RID: 3062 RVA: 0x00007DA8 File Offset: 0x00005FA8
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000385 RID: 901
			// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x000306EC File Offset: 0x0002E8EC
			// (set) Token: 0x06000BF8 RID: 3064 RVA: 0x00007DB1 File Offset: 0x00005FB1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooAttributeRemovedCommand._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooAttributeRemovedCommand._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000386 RID: 902
			// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x00030714 File Offset: 0x0002E914
			// (set) Token: 0x06000BFA RID: 3066 RVA: 0x00007DCC File Offset: 0x00005FCC
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooAttributeRemovedCommand._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooAttributeRemovedCommand._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000387 RID: 903
			// (get) Token: 0x06000BFB RID: 3067 RVA: 0x00030744 File Offset: 0x0002E944
			// (set) Token: 0x06000BFC RID: 3068 RVA: 0x00007DEB File Offset: 0x00005FEB
			public unsafe VoodooAttributeRemovedCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooAttributeRemovedCommand._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooAttributeRemovedCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooAttributeRemovedCommand._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000775 RID: 1909
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000776 RID: 1910
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000777 RID: 1911
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000778 RID: 1912
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000779 RID: 1913
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400077A RID: 1914
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400077B RID: 1915
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400077C RID: 1916
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400077D RID: 1917
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
