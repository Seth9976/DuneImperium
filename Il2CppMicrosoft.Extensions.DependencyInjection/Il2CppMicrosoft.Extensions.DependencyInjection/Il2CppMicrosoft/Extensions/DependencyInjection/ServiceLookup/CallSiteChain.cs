using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;

namespace Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup
{
	// Token: 0x02000012 RID: 18
	public sealed class CallSiteChain : Object
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00005A78 File Offset: 0x00003C78
		// Note: this type is marked as 'beforefieldinit'.
		static CallSiteChain()
		{
			Il2CppClassPointerStore<CallSiteChain>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection.ServiceLookup", "CallSiteChain");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallSiteChain>.NativeClassPtr);
			CallSiteChain.NativeFieldInfoPtr__callSiteChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteChain>.NativeClassPtr, "_callSiteChain");
			CallSiteChain.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteChain>.NativeClassPtr, 100663411);
			CallSiteChain.NativeMethodInfoPtr_CheckCircularDependency_Public_Void_ServiceIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteChain>.NativeClassPtr, 100663412);
			CallSiteChain.NativeMethodInfoPtr_Remove_Public_Void_ServiceIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteChain>.NativeClassPtr, 100663413);
			CallSiteChain.NativeMethodInfoPtr_Add_Public_Void_ServiceIdentifier_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteChain>.NativeClassPtr, 100663414);
			CallSiteChain.NativeMethodInfoPtr_CreateCircularDependencyExceptionMessage_Private_String_ServiceIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteChain>.NativeClassPtr, 100663415);
			CallSiteChain.NativeMethodInfoPtr_AppendResolutionPath_Private_Void_StringBuilder_ServiceIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteChain>.NativeClassPtr, 100663416);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00005B34 File Offset: 0x00003D34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1203788, RefRangeEnd = 1203790, XrefRangeStart = 1203780, XrefRangeEnd = 1203788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallSiteChain()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallSiteChain>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteChain.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00005B70 File Offset: 0x00003D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203790, XrefRangeEnd = 1203793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckCircularDependency(ServiceIdentifier serviceIdentifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(serviceIdentifier));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteChain.NativeMethodInfoPtr_CheckCircularDependency_Public_Void_ServiceIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00005BB8 File Offset: 0x00003DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203793, XrefRangeEnd = 1203796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(ServiceIdentifier serviceIdentifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(serviceIdentifier));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteChain.NativeMethodInfoPtr_Remove_Public_Void_ServiceIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00005C00 File Offset: 0x00003E00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1203803, RefRangeEnd = 1203805, XrefRangeStart = 1203796, XrefRangeEnd = 1203803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(ServiceIdentifier serviceIdentifier, Type implementationType = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(serviceIdentifier));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(implementationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteChain.NativeMethodInfoPtr_Add_Public_Void_ServiceIdentifier_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00005C5C File Offset: 0x00003E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203805, XrefRangeEnd = 1203827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateCircularDependencyExceptionMessage(ServiceIdentifier serviceIdentifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(serviceIdentifier));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteChain.NativeMethodInfoPtr_CreateCircularDependencyExceptionMessage_Private_String_ServiceIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00005CAC File Offset: 0x00003EAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1203895, RefRangeEnd = 1203896, XrefRangeStart = 1203827, XrefRangeEnd = 1203895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendResolutionPath(StringBuilder builder, ServiceIdentifier currentlyResolving)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(currentlyResolving));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteChain.NativeMethodInfoPtr_AppendResolutionPath_Private_Void_StringBuilder_ServiceIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000023E6 File Offset: 0x000005E6
		public CallSiteChain(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00005D08 File Offset: 0x00003F08
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x000023EF File Offset: 0x000005EF
		public unsafe Dictionary<ServiceIdentifier, CallSiteChain.ChainItemInfo> _callSiteChain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteChain.NativeFieldInfoPtr__callSiteChain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ServiceIdentifier, CallSiteChain.ChainItemInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteChain.NativeFieldInfoPtr__callSiteChain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeFieldInfoPtr__callSiteChain;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_CheckCircularDependency_Public_Void_ServiceIdentifier_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_ServiceIdentifier_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_ServiceIdentifier_Type_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_CreateCircularDependencyExceptionMessage_Private_String_ServiceIdentifier_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_AppendResolutionPath_Private_Void_StringBuilder_ServiceIdentifier_0;

		// Token: 0x02000037 RID: 55
		public sealed class ChainItemInfo : ValueType
		{
			// Token: 0x06000267 RID: 615 RVA: 0x0000CBFC File Offset: 0x0000ADFC
			// Note: this type is marked as 'beforefieldinit'.
			static ChainItemInfo()
			{
				Il2CppClassPointerStore<CallSiteChain.ChainItemInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallSiteChain>.NativeClassPtr, "ChainItemInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallSiteChain.ChainItemInfo>.NativeClassPtr);
				CallSiteChain.ChainItemInfo.NativeFieldInfoPtr__Order_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteChain.ChainItemInfo>.NativeClassPtr, "<Order>k__BackingField");
				CallSiteChain.ChainItemInfo.NativeFieldInfoPtr__ImplementationType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteChain.ChainItemInfo>.NativeClassPtr, "<ImplementationType>k__BackingField");
				CallSiteChain.ChainItemInfo.NativeMethodInfoPtr_get_Order_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteChain.ChainItemInfo>.NativeClassPtr, 100663417);
				CallSiteChain.ChainItemInfo.NativeMethodInfoPtr_get_ImplementationType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteChain.ChainItemInfo>.NativeClassPtr, 100663418);
				CallSiteChain.ChainItemInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteChain.ChainItemInfo>.NativeClassPtr, 100663419);
			}

			// Token: 0x170000BE RID: 190
			// (get) Token: 0x06000268 RID: 616 RVA: 0x0000CC8C File Offset: 0x0000AE8C
			public unsafe int Order
			{
				[CallerCount(200)]
				[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteChain.ChainItemInfo.NativeMethodInfoPtr_get_Order_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170000BF RID: 191
			// (get) Token: 0x06000269 RID: 617 RVA: 0x0000CCD0 File Offset: 0x0000AED0
			public unsafe Type ImplementationType
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteChain.ChainItemInfo.NativeMethodInfoPtr_get_ImplementationType_Public_get_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
			}

			// Token: 0x0600026A RID: 618 RVA: 0x0000CD14 File Offset: 0x0000AF14
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 344943, RefRangeEnd = 345022, XrefRangeStart = 344943, XrefRangeEnd = 345022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ChainItemInfo(int order, Type implementationType)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallSiteChain.ChainItemInfo>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref order;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(implementationType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteChain.ChainItemInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600026B RID: 619 RVA: 0x00002E3B File Offset: 0x0000103B
			public ChainItemInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600026C RID: 620 RVA: 0x00002E44 File Offset: 0x00001044
			public ChainItemInfo()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallSiteChain.ChainItemInfo>.NativeClassPtr))
			{
			}

			// Token: 0x170000BC RID: 188
			// (get) Token: 0x0600026D RID: 621 RVA: 0x0000CD74 File Offset: 0x0000AF74
			// (set) Token: 0x0600026E RID: 622 RVA: 0x00002E56 File Offset: 0x00001056
			public unsafe int _Order_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteChain.ChainItemInfo.NativeFieldInfoPtr__Order_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteChain.ChainItemInfo.NativeFieldInfoPtr__Order_k__BackingField)) = value;
				}
			}

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x0600026F RID: 623 RVA: 0x0000CD9C File Offset: 0x0000AF9C
			// (set) Token: 0x06000270 RID: 624 RVA: 0x00002E71 File Offset: 0x00001071
			public unsafe Type _ImplementationType_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteChain.ChainItemInfo.NativeFieldInfoPtr__ImplementationType_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteChain.ChainItemInfo.NativeFieldInfoPtr__ImplementationType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001B6 RID: 438
			private static readonly IntPtr NativeFieldInfoPtr__Order_k__BackingField;

			// Token: 0x040001B7 RID: 439
			private static readonly IntPtr NativeFieldInfoPtr__ImplementationType_k__BackingField;

			// Token: 0x040001B8 RID: 440
			private static readonly IntPtr NativeMethodInfoPtr_get_Order_Public_get_Int32_0;

			// Token: 0x040001B9 RID: 441
			private static readonly IntPtr NativeMethodInfoPtr_get_ImplementationType_Public_get_Type_0;

			// Token: 0x040001BA RID: 442
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Type_0;
		}

		// Token: 0x02000038 RID: 56
		[ObfuscatedName("Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteChain+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000271 RID: 625 RVA: 0x0000CDCC File Offset: 0x0000AFCC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CallSiteChain.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallSiteChain>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallSiteChain.__c>.NativeClassPtr);
				CallSiteChain.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteChain.__c>.NativeClassPtr, "<>9");
				CallSiteChain.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteChain.__c>.NativeClassPtr, "<>9__6_0");
				CallSiteChain.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteChain.__c>.NativeClassPtr, 100663421);
				CallSiteChain.__c.NativeMethodInfoPtr__AppendResolutionPath_b__6_0_Internal_Int32_KeyValuePair_2_ServiceIdentifier_ChainItemInfo_KeyValuePair_2_ServiceIdentifier_ChainItemInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteChain.__c>.NativeClassPtr, 100663422);
			}

			// Token: 0x06000272 RID: 626 RVA: 0x0000CE48 File Offset: 0x0000B048
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallSiteChain.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteChain.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000273 RID: 627 RVA: 0x0000CE84 File Offset: 0x0000B084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203778, XrefRangeEnd = 1203780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _AppendResolutionPath_b__6_0(KeyValuePair<ServiceIdentifier, CallSiteChain.ChainItemInfo> a, KeyValuePair<ServiceIdentifier, CallSiteChain.ChainItemInfo> b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteChain.__c.NativeMethodInfoPtr__AppendResolutionPath_b__6_0_Internal_Int32_KeyValuePair_2_ServiceIdentifier_ChainItemInfo_KeyValuePair_2_ServiceIdentifier_ChainItemInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000274 RID: 628 RVA: 0x00002E90 File Offset: 0x00001090
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x06000275 RID: 629 RVA: 0x0000CEF0 File Offset: 0x0000B0F0
			// (set) Token: 0x06000276 RID: 630 RVA: 0x00002E99 File Offset: 0x00001099
			public unsafe static CallSiteChain.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CallSiteChain.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallSiteChain.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CallSiteChain.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C1 RID: 193
			// (get) Token: 0x06000277 RID: 631 RVA: 0x0000CF18 File Offset: 0x0000B118
			// (set) Token: 0x06000278 RID: 632 RVA: 0x00002EAB File Offset: 0x000010AB
			public unsafe static Comparison<KeyValuePair<ServiceIdentifier, CallSiteChain.ChainItemInfo>> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CallSiteChain.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<KeyValuePair<ServiceIdentifier, CallSiteChain.ChainItemInfo>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CallSiteChain.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001BB RID: 443
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040001BC RID: 444
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x040001BD RID: 445
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001BE RID: 446
			private static readonly IntPtr NativeMethodInfoPtr__AppendResolutionPath_b__6_0_Internal_Int32_KeyValuePair_2_ServiceIdentifier_ChainItemInfo_KeyValuePair_2_ServiceIdentifier_ChainItemInfo_0;
		}
	}
}
