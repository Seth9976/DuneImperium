using System;
using dwd.core.commands;
using dwd.core.eventTriggers.clientTriggers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Networking.eventtriggers.clientactions;

namespace dwd.core.match.commands
{
	// Token: 0x0200016D RID: 365
	public class ClientEventCommands : Object
	{
		// Token: 0x0600151E RID: 5406 RVA: 0x0006890C File Offset: 0x00066B0C
		// Note: this type is marked as 'beforefieldinit'.
		static ClientEventCommands()
		{
			Il2CppClassPointerStore<ClientEventCommands>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.commands", "ClientEventCommands");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientEventCommands>.NativeClassPtr);
			ClientEventCommands.NativeFieldInfoPtr_translatorsLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventCommands>.NativeClassPtr, "translatorsLookup");
			ClientEventCommands.NativeMethodInfoPtr_Initialize_Public_Static_Void_IEnumerable_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventCommands>.NativeClassPtr, 100666481);
			ClientEventCommands.NativeMethodInfoPtr_Create_Public_Command_ClientTrigger_ClientAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventCommands>.NativeClassPtr, 100666482);
			ClientEventCommands.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventCommands>.NativeClassPtr, 100666483);
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x0006898C File Offset: 0x00066B8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 875606, RefRangeEnd = 875607, XrefRangeStart = 875494, XrefRangeEnd = 875606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(IEnumerable<Type> types)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(types);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventCommands.NativeMethodInfoPtr_Initialize_Public_Static_Void_IEnumerable_1_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x000689C4 File Offset: 0x00066BC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 875631, RefRangeEnd = 875632, XrefRangeStart = 875607, XrefRangeEnd = 875631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Command Create(ClientTrigger clientTrigger, ClientAction clientAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clientTrigger);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clientAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventCommands.NativeMethodInfoPtr_Create_Public_Command_ClientTrigger_ClientAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x00068A28 File Offset: 0x00066C28
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientEventCommands()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientEventCommands>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventCommands.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x0000955F File Offset: 0x0000775F
		public ClientEventCommands(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001523 RID: 5411 RVA: 0x00068A64 File Offset: 0x00066C64
		// (set) Token: 0x06001524 RID: 5412 RVA: 0x00009568 File Offset: 0x00007768
		public unsafe static Dictionary<ClientEventCommands.ClientTriggerActionPair, ClientEventCommands.Translator> translatorsLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ClientEventCommands.NativeFieldInfoPtr_translatorsLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ClientEventCommands.ClientTriggerActionPair, ClientEventCommands.Translator>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClientEventCommands.NativeFieldInfoPtr_translatorsLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F0E RID: 3854
		private static readonly IntPtr NativeFieldInfoPtr_translatorsLookup;

		// Token: 0x04000F0F RID: 3855
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_IEnumerable_1_Type_0;

		// Token: 0x04000F10 RID: 3856
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Command_ClientTrigger_ClientAction_0;

		// Token: 0x04000F11 RID: 3857
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002E7 RID: 743
		public sealed class ClientTriggerActionPair : ValueType
		{
			// Token: 0x06002271 RID: 8817 RVA: 0x00098CE8 File Offset: 0x00096EE8
			// Note: this type is marked as 'beforefieldinit'.
			static ClientTriggerActionPair()
			{
				Il2CppClassPointerStore<ClientEventCommands.ClientTriggerActionPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientEventCommands>.NativeClassPtr, "ClientTriggerActionPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientEventCommands.ClientTriggerActionPair>.NativeClassPtr);
				ClientEventCommands.ClientTriggerActionPair.NativeFieldInfoPtr_ClientTriggerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventCommands.ClientTriggerActionPair>.NativeClassPtr, "ClientTriggerType");
				ClientEventCommands.ClientTriggerActionPair.NativeFieldInfoPtr_ClientActionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventCommands.ClientTriggerActionPair>.NativeClassPtr, "ClientActionType");
				ClientEventCommands.ClientTriggerActionPair.NativeMethodInfoPtr__ctor_Public_Void_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventCommands.ClientTriggerActionPair>.NativeClassPtr, 100666484);
				ClientEventCommands.ClientTriggerActionPair.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventCommands.ClientTriggerActionPair>.NativeClassPtr, 100666485);
				ClientEventCommands.ClientTriggerActionPair.NativeMethodInfoPtr_Equals_Public_Boolean_ClientTriggerActionPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventCommands.ClientTriggerActionPair>.NativeClassPtr, 100666486);
				ClientEventCommands.ClientTriggerActionPair.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventCommands.ClientTriggerActionPair>.NativeClassPtr, 100666487);
			}

			// Token: 0x06002272 RID: 8818 RVA: 0x00098D8C File Offset: 0x00096F8C
			[CallerCount(238)]
			[CachedScanResults(RefRangeStart = 342357, RefRangeEnd = 342595, XrefRangeStart = 342357, XrefRangeEnd = 342595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClientTriggerActionPair(Type clientTriggerType, Type clientActionType)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientEventCommands.ClientTriggerActionPair>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(clientTriggerType);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clientActionType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventCommands.ClientTriggerActionPair.NativeMethodInfoPtr__ctor_Public_Void_Type_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002273 RID: 8819 RVA: 0x00098DF0 File Offset: 0x00096FF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875455, XrefRangeEnd = 875462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventCommands.ClientTriggerActionPair.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002274 RID: 8820 RVA: 0x00098E44 File Offset: 0x00097044
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875462, XrefRangeEnd = 875466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Equals(ClientEventCommands.ClientTriggerActionPair other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventCommands.ClientTriggerActionPair.NativeMethodInfoPtr_Equals_Public_Boolean_ClientTriggerActionPair_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002275 RID: 8821 RVA: 0x00098E9C File Offset: 0x0009709C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875466, XrefRangeEnd = 875472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventCommands.ClientTriggerActionPair.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002276 RID: 8822 RVA: 0x0000ECA7 File Offset: 0x0000CEA7
			public ClientTriggerActionPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002277 RID: 8823 RVA: 0x0000ECB0 File Offset: 0x0000CEB0
			public ClientTriggerActionPair()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientEventCommands.ClientTriggerActionPair>.NativeClassPtr))
			{
			}

			// Token: 0x1700096C RID: 2412
			// (get) Token: 0x06002278 RID: 8824 RVA: 0x00098EE0 File Offset: 0x000970E0
			// (set) Token: 0x06002279 RID: 8825 RVA: 0x0000ECC2 File Offset: 0x0000CEC2
			public unsafe Type ClientTriggerType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventCommands.ClientTriggerActionPair.NativeFieldInfoPtr_ClientTriggerType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventCommands.ClientTriggerActionPair.NativeFieldInfoPtr_ClientTriggerType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700096D RID: 2413
			// (get) Token: 0x0600227A RID: 8826 RVA: 0x00098F10 File Offset: 0x00097110
			// (set) Token: 0x0600227B RID: 8827 RVA: 0x0000ECE1 File Offset: 0x0000CEE1
			public unsafe Type ClientActionType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventCommands.ClientTriggerActionPair.NativeFieldInfoPtr_ClientActionType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventCommands.ClientTriggerActionPair.NativeFieldInfoPtr_ClientActionType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017D0 RID: 6096
			private static readonly IntPtr NativeFieldInfoPtr_ClientTriggerType;

			// Token: 0x040017D1 RID: 6097
			private static readonly IntPtr NativeFieldInfoPtr_ClientActionType;

			// Token: 0x040017D2 RID: 6098
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Type_0;

			// Token: 0x040017D3 RID: 6099
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x040017D4 RID: 6100
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_ClientTriggerActionPair_0;

			// Token: 0x040017D5 RID: 6101
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
		}

		// Token: 0x020002E8 RID: 744
		public sealed class Translator : ValueType
		{
			// Token: 0x0600227C RID: 8828 RVA: 0x00098F40 File Offset: 0x00097140
			// Note: this type is marked as 'beforefieldinit'.
			static Translator()
			{
				Il2CppClassPointerStore<ClientEventCommands.Translator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientEventCommands>.NativeClassPtr, "Translator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientEventCommands.Translator>.NativeClassPtr);
				ClientEventCommands.Translator.NativeFieldInfoPtr_invoke = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventCommands.Translator>.NativeClassPtr, "invoke");
				ClientEventCommands.Translator.NativeFieldInfoPtr_paramTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventCommands.Translator>.NativeClassPtr, "paramTypes");
				ClientEventCommands.Translator.NativeMethodInfoPtr__ctor_Public_Void_Func_2_Il2CppReferenceArray_1_Object_Object_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventCommands.Translator>.NativeClassPtr, 100666488);
				ClientEventCommands.Translator.NativeMethodInfoPtr_Invoke_Public_Command_ClientTrigger_ClientAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventCommands.Translator>.NativeClassPtr, 100666489);
			}

			// Token: 0x0600227D RID: 8829 RVA: 0x00098FBC File Offset: 0x000971BC
			[CallerCount(238)]
			[CachedScanResults(RefRangeStart = 342357, RefRangeEnd = 342595, XrefRangeStart = 342357, XrefRangeEnd = 342595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Translator(Func<Il2CppReferenceArray<Object>, Object> invoke, Il2CppReferenceArray<Type> paramTypes)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientEventCommands.Translator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(invoke);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramTypes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventCommands.Translator.NativeMethodInfoPtr__ctor_Public_Void_Func_2_Il2CppReferenceArray_1_Object_Object_Il2CppReferenceArray_1_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600227E RID: 8830 RVA: 0x00099020 File Offset: 0x00097220
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 875493, RefRangeEnd = 875494, XrefRangeStart = 875472, XrefRangeEnd = 875493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Command Invoke(ClientTrigger trigger, ClientAction action)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(trigger);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventCommands.Translator.NativeMethodInfoPtr_Invoke_Public_Command_ClientTrigger_ClientAction_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}

			// Token: 0x0600227F RID: 8831 RVA: 0x0000ED00 File Offset: 0x0000CF00
			public Translator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002280 RID: 8832 RVA: 0x0000ED09 File Offset: 0x0000CF09
			public Translator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientEventCommands.Translator>.NativeClassPtr))
			{
			}

			// Token: 0x1700096E RID: 2414
			// (get) Token: 0x06002281 RID: 8833 RVA: 0x00099088 File Offset: 0x00097288
			// (set) Token: 0x06002282 RID: 8834 RVA: 0x0000ED1B File Offset: 0x0000CF1B
			public unsafe Func<Il2CppReferenceArray<Object>, Object> invoke
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventCommands.Translator.NativeFieldInfoPtr_invoke);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppReferenceArray<Object>, Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventCommands.Translator.NativeFieldInfoPtr_invoke), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700096F RID: 2415
			// (get) Token: 0x06002283 RID: 8835 RVA: 0x000990B8 File Offset: 0x000972B8
			// (set) Token: 0x06002284 RID: 8836 RVA: 0x0000ED3A File Offset: 0x0000CF3A
			public unsafe Il2CppReferenceArray<Type> paramTypes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventCommands.Translator.NativeFieldInfoPtr_paramTypes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventCommands.Translator.NativeFieldInfoPtr_paramTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017D6 RID: 6102
			private static readonly IntPtr NativeFieldInfoPtr_invoke;

			// Token: 0x040017D7 RID: 6103
			private static readonly IntPtr NativeFieldInfoPtr_paramTypes;

			// Token: 0x040017D8 RID: 6104
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_2_Il2CppReferenceArray_1_Object_Object_Il2CppReferenceArray_1_Type_0;

			// Token: 0x040017D9 RID: 6105
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Command_ClientTrigger_ClientAction_0;
		}

		// Token: 0x020002E9 RID: 745
		[ObfuscatedName("dwd.core.match.commands.ClientEventCommands+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002285 RID: 8837 RVA: 0x000990E8 File Offset: 0x000972E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ClientEventCommands.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientEventCommands>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientEventCommands.__c>.NativeClassPtr);
				ClientEventCommands.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventCommands.__c>.NativeClassPtr, "<>9");
				ClientEventCommands.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventCommands.__c>.NativeClassPtr, "<>9__2_0");
				ClientEventCommands.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventCommands.__c>.NativeClassPtr, 100666491);
				ClientEventCommands.__c.NativeMethodInfoPtr__Initialize_b__2_0_Internal_Type_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventCommands.__c>.NativeClassPtr, 100666492);
			}

			// Token: 0x06002286 RID: 8838 RVA: 0x00099164 File Offset: 0x00097364
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientEventCommands.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventCommands.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002287 RID: 8839 RVA: 0x000991A0 File Offset: 0x000973A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Type _Initialize_b__2_0(ParameterInfo param)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(param);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventCommands.__c.NativeMethodInfoPtr__Initialize_b__2_0_Internal_Type_ParameterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
			}

			// Token: 0x06002288 RID: 8840 RVA: 0x0000ED59 File Offset: 0x0000CF59
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000970 RID: 2416
			// (get) Token: 0x06002289 RID: 8841 RVA: 0x000991F0 File Offset: 0x000973F0
			// (set) Token: 0x0600228A RID: 8842 RVA: 0x0000ED62 File Offset: 0x0000CF62
			public unsafe static ClientEventCommands.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ClientEventCommands.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventCommands.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ClientEventCommands.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000971 RID: 2417
			// (get) Token: 0x0600228B RID: 8843 RVA: 0x00099218 File Offset: 0x00097418
			// (set) Token: 0x0600228C RID: 8844 RVA: 0x0000ED74 File Offset: 0x0000CF74
			public unsafe static Func<ParameterInfo, Type> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ClientEventCommands.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ParameterInfo, Type>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ClientEventCommands.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017DA RID: 6106
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040017DB RID: 6107
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x040017DC RID: 6108
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040017DD RID: 6109
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__2_0_Internal_Type_ParameterInfo_0;
		}
	}
}
