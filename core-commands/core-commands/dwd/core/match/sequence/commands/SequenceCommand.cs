using System;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;

namespace dwd.core.match.sequence.commands
{
	// Token: 0x0200000D RID: 13
	public class SequenceCommand : Command
	{
		// Token: 0x06000051 RID: 81 RVA: 0x00005A24 File Offset: 0x00003C24
		// Note: this type is marked as 'beforefieldinit'.
		static SequenceCommand()
		{
			Il2CppClassPointerStore<SequenceCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.match.sequence.commands", "SequenceCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceCommand>.NativeClassPtr);
			SequenceCommand.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceCommand>.NativeClassPtr, "ID");
			SequenceCommand.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceCommand>.NativeClassPtr, "Name");
			SequenceCommand.NativeFieldInfoPtr_sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceCommand>.NativeClassPtr, "sequence");
			SequenceCommand.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceCommand>.NativeClassPtr, "attributes");
			SequenceCommand.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceCommand>.NativeClassPtr, "parent");
			SequenceCommand.NativeMethodInfoPtr__ctor_Protected_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommand>.NativeClassPtr, 100663331);
			SequenceCommand.NativeMethodInfoPtr_get_Sequence_Public_get_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommand>.NativeClassPtr, 100663332);
			SequenceCommand.NativeMethodInfoPtr_AssignParent_Public_Void_SequenceCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommand>.NativeClassPtr, 100663333);
			SequenceCommand.NativeMethodInfoPtr_GetAttribute_Public_Virtual_Final_New_IAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommand>.NativeClassPtr, 100663334);
			SequenceCommand.NativeMethodInfoPtr_GetAttribute_Public_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommand>.NativeClassPtr, 100663335);
			SequenceCommand.NativeMethodInfoPtr_SetAttributes_Public_Void_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommand>.NativeClassPtr, 100663336);
			SequenceCommand.NativeMethodInfoPtr_HasAttribute_Public_Boolean_AttributeDefinition_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommand>.NativeClassPtr, 100663337);
			SequenceCommand.NativeMethodInfoPtr_execute_Protected_Virtual_Final_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommand>.NativeClassPtr, 100663338);
			SequenceCommand.NativeMethodInfoPtr_LogMessage_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommand>.NativeClassPtr, 100663339);
			SequenceCommand.NativeMethodInfoPtr_LogMessage_Public_Void_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommand>.NativeClassPtr, 100663340);
			SequenceCommand.NativeMethodInfoPtr_executeSequence_Protected_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommand>.NativeClassPtr, 100663341);
			SequenceCommand.NativeMethodInfoPtr_getAttributes_Protected_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommand>.NativeClassPtr, 100663342);
			SequenceCommand.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommand>.NativeClassPtr, 100663343);
			SequenceCommand.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommand>.NativeClassPtr, 100663344);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00005BD0 File Offset: 0x00003DD0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1206103, RefRangeEnd = 1206112, XrefRangeStart = 1206074, XrefRangeEnd = 1206103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceCommand(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceCommand>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommand.NativeMethodInfoPtr__ctor_Protected_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00005C40 File Offset: 0x00003E40
		public unsafe IList<Command> Sequence
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommand.NativeMethodInfoPtr_get_Sequence_Public_get_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Command>>(intPtr3) : null;
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00005C80 File Offset: 0x00003E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignParent(SequenceCommand parentSequenceCommand)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentSequenceCommand);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommand.NativeMethodInfoPtr_AssignParent_Public_Void_SequenceCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00005CC4 File Offset: 0x00003EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206112, XrefRangeEnd = 1206122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAttribute GetAttribute(int key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommand.NativeMethodInfoPtr_GetAttribute_Public_Virtual_Final_New_IAttribute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00005D10 File Offset: 0x00003F10
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1206128, RefRangeEnd = 1206154, XrefRangeStart = 1206122, XrefRangeEnd = 1206128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAttribute<V> GetAttribute<V>(AttributeDefinition<V> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommand.MethodInfoStoreGeneric_GetAttribute_Public_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0<V>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute<V>>(intPtr3) : null;
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00005D60 File Offset: 0x00003F60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1206160, RefRangeEnd = 1206162, XrefRangeStart = 1206154, XrefRangeEnd = 1206160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAttributes(ReadOnlyAttributes newAttributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newAttributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommand.NativeMethodInfoPtr_SetAttributes_Public_Void_ReadOnlyAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00005DA4 File Offset: 0x00003FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206162, XrefRangeEnd = 1206163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasAttribute<V>(AttributeDefinition<V> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommand.MethodInfoStoreGeneric_HasAttribute_Public_Boolean_AttributeDefinition_1_V_0<V>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00005DF4 File Offset: 0x00003FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206163, XrefRangeEnd = 1206168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommand.NativeMethodInfoPtr_execute_Protected_Virtual_Final_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00005E34 File Offset: 0x00004034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206168, XrefRangeEnd = 1206174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string LogMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommand.NativeMethodInfoPtr_LogMessage_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00005E6C File Offset: 0x0000406C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1206206, RefRangeEnd = 1206209, XrefRangeStart = 1206174, XrefRangeEnd = 1206206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogMessage(StringBuilder builder, int depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommand.NativeMethodInfoPtr_LogMessage_Public_Void_StringBuilder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00005EBC File Offset: 0x000040BC
		[CallerCount(0)]
		public unsafe virtual IEnumerator executeSequence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SequenceCommand.NativeMethodInfoPtr_executeSequence_Protected_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00005F08 File Offset: 0x00004108
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1206214, RefRangeEnd = 1206215, XrefRangeStart = 1206209, XrefRangeEnd = 1206214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IHasAttributes getAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommand.NativeMethodInfoPtr_getAttributes_Protected_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHasAttributes>(intPtr3) : null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00005F48 File Offset: 0x00004148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206215, XrefRangeEnd = 1206224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<IAttribute> System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommand.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAttribute>>(intPtr3) : null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00005F88 File Offset: 0x00004188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206224, XrefRangeEnd = 1206233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommand.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002311 File Offset: 0x00000511
		public SequenceCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00005FC8 File Offset: 0x000041C8
		// (set) Token: 0x06000062 RID: 98 RVA: 0x0000231A File Offset: 0x0000051A
		public unsafe SequenceID ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommand.NativeFieldInfoPtr_ID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommand.NativeFieldInfoPtr_ID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00005FF8 File Offset: 0x000041F8
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00002339 File Offset: 0x00000539
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommand.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommand.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00006020 File Offset: 0x00004220
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00002358 File Offset: 0x00000558
		public unsafe IList<Command> sequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommand.NativeFieldInfoPtr_sequence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<Command>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommand.NativeFieldInfoPtr_sequence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00006050 File Offset: 0x00004250
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00002377 File Offset: 0x00000577
		public unsafe ReadOnlyAttributes attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommand.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommand.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00006080 File Offset: 0x00004280
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00002396 File Offset: 0x00000596
		public unsafe SequenceCommand parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommand.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommand.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr_sequence;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SequenceID_String_IList_1_Command_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_get_Sequence_Public_get_IList_1_Command_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_AssignParent_Public_Void_SequenceCommand_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_Final_New_IAttribute_Int32_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_SetAttributes_Public_Void_ReadOnlyAttributes_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_HasAttribute_Public_Boolean_AttributeDefinition_1_V_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_Final_IEnumerator_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_LogMessage_Public_String_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_LogMessage_Public_Void_StringBuilder_Int32_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_executeSequence_Protected_Abstract_Virtual_New_IEnumerator_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_getAttributes_Protected_IHasAttributes_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0200003C RID: 60
		[ObfuscatedName("dwd.core.match.sequence.commands.SequenceCommand+<execute>d__13")]
		public sealed class _execute_d__13 : Object
		{
			// Token: 0x06000235 RID: 565 RVA: 0x0000D198 File Offset: 0x0000B398
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__13()
			{
				Il2CppClassPointerStore<SequenceCommand._execute_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceCommand>.NativeClassPtr, "<execute>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceCommand._execute_d__13>.NativeClassPtr);
				SequenceCommand._execute_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceCommand._execute_d__13>.NativeClassPtr, "<>1__state");
				SequenceCommand._execute_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceCommand._execute_d__13>.NativeClassPtr, "<>2__current");
				SequenceCommand._execute_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceCommand._execute_d__13>.NativeClassPtr, "<>4__this");
				SequenceCommand._execute_d__13.NativeFieldInfoPtr__context_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceCommand._execute_d__13>.NativeClassPtr, "<context>5__2");
				SequenceCommand._execute_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommand._execute_d__13>.NativeClassPtr, 100663345);
				SequenceCommand._execute_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommand._execute_d__13>.NativeClassPtr, 100663346);
				SequenceCommand._execute_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommand._execute_d__13>.NativeClassPtr, 100663347);
				SequenceCommand._execute_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommand._execute_d__13>.NativeClassPtr, 100663348);
				SequenceCommand._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommand._execute_d__13>.NativeClassPtr, 100663349);
				SequenceCommand._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommand._execute_d__13>.NativeClassPtr, 100663350);
			}

			// Token: 0x06000236 RID: 566 RVA: 0x0000D28C File Offset: 0x0000B48C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceCommand._execute_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommand._execute_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000237 RID: 567 RVA: 0x0000D2D4 File Offset: 0x0000B4D4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommand._execute_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000238 RID: 568 RVA: 0x0000D308 File Offset: 0x0000B508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206061, XrefRangeEnd = 1206069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommand._execute_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x06000239 RID: 569 RVA: 0x0000D344 File Offset: 0x0000B544
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommand._execute_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600023A RID: 570 RVA: 0x0000D384 File Offset: 0x0000B584
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206069, XrefRangeEnd = 1206074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommand._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x0600023B RID: 571 RVA: 0x0000D3B8 File Offset: 0x0000B5B8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommand._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600023C RID: 572 RVA: 0x00002F30 File Offset: 0x00001130
			public _execute_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x0600023D RID: 573 RVA: 0x0000D3F8 File Offset: 0x0000B5F8
			// (set) Token: 0x0600023E RID: 574 RVA: 0x00002F39 File Offset: 0x00001139
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommand._execute_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommand._execute_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x0600023F RID: 575 RVA: 0x0000D420 File Offset: 0x0000B620
			// (set) Token: 0x06000240 RID: 576 RVA: 0x00002F54 File Offset: 0x00001154
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommand._execute_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommand._execute_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x06000241 RID: 577 RVA: 0x0000D450 File Offset: 0x0000B650
			// (set) Token: 0x06000242 RID: 578 RVA: 0x00002F73 File Offset: 0x00001173
			public unsafe SequenceCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommand._execute_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommand._execute_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x06000243 RID: 579 RVA: 0x0000D480 File Offset: 0x0000B680
			// (set) Token: 0x06000244 RID: 580 RVA: 0x00002F92 File Offset: 0x00001192
			public unsafe IEnumerator _context_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommand._execute_d__13.NativeFieldInfoPtr__context_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommand._execute_d__13.NativeFieldInfoPtr__context_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000159 RID: 345
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400015A RID: 346
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400015B RID: 347
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400015C RID: 348
			private static readonly IntPtr NativeFieldInfoPtr__context_5__2;

			// Token: 0x0400015D RID: 349
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400015E RID: 350
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400015F RID: 351
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000160 RID: 352
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000161 RID: 353
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000162 RID: 354
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200003D RID: 61
		private sealed class MethodInfoStoreGeneric_GetAttribute_Public_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0<V>
		{
			// Token: 0x04000163 RID: 355
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceCommand.NativeMethodInfoPtr_GetAttribute_Public_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0, Il2CppClassPointerStore<SequenceCommand>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr)) }))));
		}

		// Token: 0x0200003E RID: 62
		private sealed class MethodInfoStoreGeneric_HasAttribute_Public_Boolean_AttributeDefinition_1_V_0<V>
		{
			// Token: 0x04000164 RID: 356
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceCommand.NativeMethodInfoPtr_HasAttribute_Public_Boolean_AttributeDefinition_1_V_0, Il2CppClassPointerStore<SequenceCommand>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr)) }))));
		}
	}
}
