using System;
using boardgames.match.data;
using Canis.utils.localization;
using dwd.core;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace worm.match.commands
{
	// Token: 0x02000234 RID: 564
	public class WormRunPostMatchFlow : RunPostMatchFlow
	{
		// Token: 0x06001881 RID: 6273 RVA: 0x00062890 File Offset: 0x00060A90
		// Note: this type is marked as 'beforefieldinit'.
		static WormRunPostMatchFlow()
		{
			Il2CppClassPointerStore<WormRunPostMatchFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands", "WormRunPostMatchFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRunPostMatchFlow>.NativeClassPtr);
			WormRunPostMatchFlow.NativeMethodInfoPtr__ctor_Public_Void_GameOptionsData_Boolean_Dictionary_2_LocalizableTextVariables_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRunPostMatchFlow>.NativeClassPtr, 100666693);
			WormRunPostMatchFlow.NativeMethodInfoPtr_GetDestinationFlow_Protected_Virtual_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRunPostMatchFlow>.NativeClassPtr, 100666694);
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x000628E8 File Offset: 0x00060AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718776, XrefRangeEnd = 718777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormRunPostMatchFlow(GameOptionsData gameOptions, bool returnToMenus = false, Dictionary<LocalizableTextVariables, int> dailyChallengeScore = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRunPostMatchFlow>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameOptions);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnToMenus;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dailyChallengeScore);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRunPostMatchFlow.NativeMethodInfoPtr__ctor_Public_Void_GameOptionsData_Boolean_Dictionary_2_LocalizableTextVariables_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x00062954 File Offset: 0x00060B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718777, XrefRangeEnd = 718796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Command GetDestinationFlow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormRunPostMatchFlow.NativeMethodInfoPtr_GetDestinationFlow_Protected_Virtual_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x0000E800 File Offset: 0x0000CA00
		public WormRunPostMatchFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E33 RID: 3635
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameOptionsData_Boolean_Dictionary_2_LocalizableTextVariables_Int32_0;

		// Token: 0x04000E34 RID: 3636
		private static readonly IntPtr NativeMethodInfoPtr_GetDestinationFlow_Protected_Virtual_Command_0;

		// Token: 0x02000405 RID: 1029
		[ObfuscatedName("worm.match.commands.WormRunPostMatchFlow+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002A32 RID: 10802 RVA: 0x00097DE8 File Offset: 0x00095FE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormRunPostMatchFlow.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormRunPostMatchFlow>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRunPostMatchFlow.__c>.NativeClassPtr);
				WormRunPostMatchFlow.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRunPostMatchFlow.__c>.NativeClassPtr, "<>9");
				WormRunPostMatchFlow.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRunPostMatchFlow.__c>.NativeClassPtr, "<>9__1_0");
				WormRunPostMatchFlow.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRunPostMatchFlow.__c>.NativeClassPtr, "<>9__1_1");
				WormRunPostMatchFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRunPostMatchFlow.__c>.NativeClassPtr, 100666696);
				WormRunPostMatchFlow.__c.NativeMethodInfoPtr__GetDestinationFlow_b__1_0_Internal_IEnumerator_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRunPostMatchFlow.__c>.NativeClassPtr, 100666697);
				WormRunPostMatchFlow.__c.NativeMethodInfoPtr__GetDestinationFlow_b__1_1_Internal_IEnumerator_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRunPostMatchFlow.__c>.NativeClassPtr, 100666698);
			}

			// Token: 0x06002A33 RID: 10803 RVA: 0x00097E8C File Offset: 0x0009608C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRunPostMatchFlow.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRunPostMatchFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A34 RID: 10804 RVA: 0x00097EC8 File Offset: 0x000960C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718740, XrefRangeEnd = 718744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _GetDestinationFlow_b__1_0(ErrorInfo _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRunPostMatchFlow.__c.NativeMethodInfoPtr__GetDestinationFlow_b__1_0_Internal_IEnumerator_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x06002A35 RID: 10805 RVA: 0x00097F20 File Offset: 0x00096120
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718744, XrefRangeEnd = 718776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _GetDestinationFlow_b__1_1(ErrorInfo error)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(error));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRunPostMatchFlow.__c.NativeMethodInfoPtr__GetDestinationFlow_b__1_1_Internal_IEnumerator_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x06002A36 RID: 10806 RVA: 0x0001712E File Offset: 0x0001532E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BF3 RID: 3059
			// (get) Token: 0x06002A37 RID: 10807 RVA: 0x00097F78 File Offset: 0x00096178
			// (set) Token: 0x06002A38 RID: 10808 RVA: 0x00017137 File Offset: 0x00015337
			public unsafe static WormRunPostMatchFlow.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormRunPostMatchFlow.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormRunPostMatchFlow.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormRunPostMatchFlow.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BF4 RID: 3060
			// (get) Token: 0x06002A39 RID: 10809 RVA: 0x00097FA0 File Offset: 0x000961A0
			// (set) Token: 0x06002A3A RID: 10810 RVA: 0x00017149 File Offset: 0x00015349
			public unsafe static Func<ErrorInfo, IEnumerator> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormRunPostMatchFlow.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ErrorInfo, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormRunPostMatchFlow.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BF5 RID: 3061
			// (get) Token: 0x06002A3B RID: 10811 RVA: 0x00097FC8 File Offset: 0x000961C8
			// (set) Token: 0x06002A3C RID: 10812 RVA: 0x0001715B File Offset: 0x0001535B
			public unsafe static Func<ErrorInfo, IEnumerator> __9__1_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormRunPostMatchFlow.__c.NativeFieldInfoPtr___9__1_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ErrorInfo, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormRunPostMatchFlow.__c.NativeFieldInfoPtr___9__1_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001879 RID: 6265
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400187A RID: 6266
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x0400187B RID: 6267
			private static readonly IntPtr NativeFieldInfoPtr___9__1_1;

			// Token: 0x0400187C RID: 6268
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400187D RID: 6269
			private static readonly IntPtr NativeMethodInfoPtr__GetDestinationFlow_b__1_0_Internal_IEnumerator_ErrorInfo_0;

			// Token: 0x0400187E RID: 6270
			private static readonly IntPtr NativeMethodInfoPtr__GetDestinationFlow_b__1_1_Internal_IEnumerator_ErrorInfo_0;
		}
	}
}
