using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;
using worm.canis.data.enums;

namespace worm.client.iap
{
	// Token: 0x020002A6 RID: 678
	public class IAPProductDataProvider : MonoBehaviour
	{
		// Token: 0x06001BA3 RID: 7075 RVA: 0x0006D188 File Offset: 0x0006B388
		// Note: this type is marked as 'beforefieldinit'.
		static IAPProductDataProvider()
		{
			Il2CppClassPointerStore<IAPProductDataProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.client.iap", "IAPProductDataProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPProductDataProvider>.NativeClassPtr);
			IAPProductDataProvider.NativeFieldInfoPtr_productSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProductDataProvider>.NativeClassPtr, "productSet");
			IAPProductDataProvider.NativeFieldInfoPtr_onProductHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProductDataProvider>.NativeClassPtr, "onProductHidden");
			IAPProductDataProvider.NativeFieldInfoPtr_onProductUnavailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProductDataProvider>.NativeClassPtr, "onProductUnavailable");
			IAPProductDataProvider.NativeFieldInfoPtr_subscriptionProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProductDataProvider>.NativeClassPtr, "subscriptionProvider");
			IAPProductDataProvider.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProductDataProvider>.NativeClassPtr, 100667326);
			IAPProductDataProvider.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProductDataProvider>.NativeClassPtr, 100667327);
			IAPProductDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProductDataProvider>.NativeClassPtr, 100667328);
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x0006D244 File Offset: 0x0006B444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725239, XrefRangeEnd = 725243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProductDataProvider.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x0006D278 File Offset: 0x0006B478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725243, XrefRangeEnd = 725321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProductDataProvider.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x0006D2AC File Offset: 0x0006B4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725321, XrefRangeEnd = 725331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAPProductDataProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPProductDataProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProductDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x0000FF4A File Offset: 0x0000E14A
		public IAPProductDataProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x0006D2E8 File Offset: 0x0006B4E8
		// (set) Token: 0x06001BA9 RID: 7081 RVA: 0x0000FF53 File Offset: 0x0000E153
		public unsafe Set productSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductDataProvider.NativeFieldInfoPtr_productSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductDataProvider.NativeFieldInfoPtr_productSet)) = value;
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06001BAA RID: 7082 RVA: 0x0006D310 File Offset: 0x0006B510
		// (set) Token: 0x06001BAB RID: 7083 RVA: 0x0000FF6E File Offset: 0x0000E16E
		public unsafe UnityEvent onProductHidden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductDataProvider.NativeFieldInfoPtr_onProductHidden);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductDataProvider.NativeFieldInfoPtr_onProductHidden), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06001BAC RID: 7084 RVA: 0x0006D340 File Offset: 0x0006B540
		// (set) Token: 0x06001BAD RID: 7085 RVA: 0x0000FF8D File Offset: 0x0000E18D
		public unsafe UnityEvent onProductUnavailable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductDataProvider.NativeFieldInfoPtr_onProductUnavailable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductDataProvider.NativeFieldInfoPtr_onProductUnavailable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001BAE RID: 7086 RVA: 0x0006D370 File Offset: 0x0006B570
		// (set) Token: 0x06001BAF RID: 7087 RVA: 0x0000FFAC File Offset: 0x0000E1AC
		public unsafe SubscriptionProvider subscriptionProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductDataProvider.NativeFieldInfoPtr_subscriptionProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPProductDataProvider.NativeFieldInfoPtr_subscriptionProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FF6 RID: 4086
		private static readonly IntPtr NativeFieldInfoPtr_productSet;

		// Token: 0x04000FF7 RID: 4087
		private static readonly IntPtr NativeFieldInfoPtr_onProductHidden;

		// Token: 0x04000FF8 RID: 4088
		private static readonly IntPtr NativeFieldInfoPtr_onProductUnavailable;

		// Token: 0x04000FF9 RID: 4089
		private static readonly IntPtr NativeFieldInfoPtr_subscriptionProvider;

		// Token: 0x04000FFA RID: 4090
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000FFB RID: 4091
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000FFC RID: 4092
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000445 RID: 1093
		[ObfuscatedName("worm.client.iap.IAPProductDataProvider+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06002D5E RID: 11614 RVA: 0x000A1864 File Offset: 0x0009FA64
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IAPProductDataProvider.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IAPProductDataProvider>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPProductDataProvider.__c>.NativeClassPtr);
				IAPProductDataProvider.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProductDataProvider.__c>.NativeClassPtr, "<>9");
				IAPProductDataProvider.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPProductDataProvider.__c>.NativeClassPtr, "<>9__5_0");
				IAPProductDataProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProductDataProvider.__c>.NativeClassPtr, 100667330);
				IAPProductDataProvider.__c.NativeMethodInfoPtr__Start_b__5_0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPProductDataProvider.__c>.NativeClassPtr, 100667331);
			}

			// Token: 0x06002D5F RID: 11615 RVA: 0x000A18E0 File Offset: 0x0009FAE0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPProductDataProvider.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProductDataProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D60 RID: 11616 RVA: 0x000A191C File Offset: 0x0009FB1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725235, XrefRangeEnd = 725239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Start_b__5_0(string t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPProductDataProvider.__c.NativeMethodInfoPtr__Start_b__5_0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D61 RID: 11617 RVA: 0x00018972 File Offset: 0x00016B72
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D04 RID: 3332
			// (get) Token: 0x06002D62 RID: 11618 RVA: 0x000A196C File Offset: 0x0009FB6C
			// (set) Token: 0x06002D63 RID: 11619 RVA: 0x0001897B File Offset: 0x00016B7B
			public unsafe static IAPProductDataProvider.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IAPProductDataProvider.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPProductDataProvider.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IAPProductDataProvider.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D05 RID: 3333
			// (get) Token: 0x06002D64 RID: 11620 RVA: 0x000A1994 File Offset: 0x0009FB94
			// (set) Token: 0x06002D65 RID: 11621 RVA: 0x0001898D File Offset: 0x00016B8D
			public unsafe static Func<string, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IAPProductDataProvider.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IAPProductDataProvider.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A5E RID: 6750
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001A5F RID: 6751
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04001A60 RID: 6752
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001A61 RID: 6753
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__5_0_Internal_Boolean_String_0;
		}
	}
}
