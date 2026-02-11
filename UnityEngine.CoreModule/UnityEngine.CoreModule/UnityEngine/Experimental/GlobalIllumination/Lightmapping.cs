using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000279 RID: 633
	public static class Lightmapping : Object
	{
		// Token: 0x06002B34 RID: 11060 RVA: 0x000AF438 File Offset: 0x000AD638
		// Note: this type is marked as 'beforefieldinit'.
		static Lightmapping()
		{
			Il2CppClassPointerStore<Lightmapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "Lightmapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr);
			Lightmapping.NativeFieldInfoPtr_s_DefaultDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, "s_DefaultDelegate");
			Lightmapping.NativeFieldInfoPtr_s_RequestLightsDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, "s_RequestLightsDelegate");
			Lightmapping.NativeMethodInfoPtr_SetDelegate_Public_Static_Void_RequestLightsDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, 100668612);
			Lightmapping.NativeMethodInfoPtr_GetDelegate_Public_Static_RequestLightsDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, 100668613);
			Lightmapping.NativeMethodInfoPtr_ResetDelegate_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, 100668614);
			Lightmapping.NativeMethodInfoPtr_RequestLights_Internal_Static_Void_Il2CppReferenceArray_1_Light_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, 100668615);
		}

		// Token: 0x06002B35 RID: 11061 RVA: 0x000AF4E0 File Offset: 0x000AD6E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 686166, RefRangeEnd = 686167, XrefRangeStart = 686136, XrefRangeEnd = 686166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDelegate(Lightmapping.RequestLightsDelegate del)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(del);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.NativeMethodInfoPtr_SetDelegate_Public_Static_Void_RequestLightsDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B36 RID: 11062 RVA: 0x000AF518 File Offset: 0x000AD718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686167, XrefRangeEnd = 686171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Lightmapping.RequestLightsDelegate GetDelegate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.NativeMethodInfoPtr_GetDelegate_Public_Static_RequestLightsDelegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Lightmapping.RequestLightsDelegate>(intPtr3) : null;
		}

		// Token: 0x06002B37 RID: 11063 RVA: 0x000AF54C File Offset: 0x000AD74C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 686177, RefRangeEnd = 686178, XrefRangeStart = 686171, XrefRangeEnd = 686177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResetDelegate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.NativeMethodInfoPtr_ResetDelegate_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x000AF574 File Offset: 0x000AD774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686178, XrefRangeEnd = 686186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RequestLights(Il2CppReferenceArray<Light> lights, IntPtr outLightsPtr, int outLightsCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lights);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outLightsPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outLightsCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.NativeMethodInfoPtr_RequestLights_Internal_Static_Void_Il2CppReferenceArray_1_Light_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x00010E00 File Offset: 0x0000F000
		public Lightmapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06002B3A RID: 11066 RVA: 0x000AF5C8 File Offset: 0x000AD7C8
		// (set) Token: 0x06002B3B RID: 11067 RVA: 0x00010E09 File Offset: 0x0000F009
		public unsafe static Lightmapping.RequestLightsDelegate s_DefaultDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Lightmapping.NativeFieldInfoPtr_s_DefaultDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lightmapping.RequestLightsDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lightmapping.NativeFieldInfoPtr_s_DefaultDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06002B3C RID: 11068 RVA: 0x000AF5F0 File Offset: 0x000AD7F0
		// (set) Token: 0x06002B3D RID: 11069 RVA: 0x00010E1B File Offset: 0x0000F01B
		public unsafe static Lightmapping.RequestLightsDelegate s_RequestLightsDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Lightmapping.NativeFieldInfoPtr_s_RequestLightsDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lightmapping.RequestLightsDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lightmapping.NativeFieldInfoPtr_s_RequestLightsDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002654 RID: 9812
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultDelegate;

		// Token: 0x04002655 RID: 9813
		private static readonly IntPtr NativeFieldInfoPtr_s_RequestLightsDelegate;

		// Token: 0x04002656 RID: 9814
		private static readonly IntPtr NativeMethodInfoPtr_SetDelegate_Public_Static_Void_RequestLightsDelegate_0;

		// Token: 0x04002657 RID: 9815
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegate_Public_Static_RequestLightsDelegate_0;

		// Token: 0x04002658 RID: 9816
		private static readonly IntPtr NativeMethodInfoPtr_ResetDelegate_Public_Static_Void_0;

		// Token: 0x04002659 RID: 9817
		private static readonly IntPtr NativeMethodInfoPtr_RequestLights_Internal_Static_Void_Il2CppReferenceArray_1_Light_IntPtr_Int32_0;

		// Token: 0x02000A5F RID: 2655
		public sealed class RequestLightsDelegate : MulticastDelegate
		{
			// Token: 0x06003DDA RID: 15834 RVA: 0x0001680F File Offset: 0x00014A0F
			// Note: this type is marked as 'beforefieldinit'.
			static RequestLightsDelegate()
			{
				Il2CppClassPointerStore<Lightmapping.RequestLightsDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, "RequestLightsDelegate");
				Lightmapping.RequestLightsDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping.RequestLightsDelegate>.NativeClassPtr, 100668617);
				Lightmapping.RequestLightsDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping.RequestLightsDelegate>.NativeClassPtr, 100668618);
			}

			// Token: 0x06003DDB RID: 15835 RVA: 0x000BEFC8 File Offset: 0x000BD1C8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 686117, RefRangeEnd = 686118, XrefRangeStart = 686113, XrefRangeEnd = 686117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RequestLightsDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lightmapping.RequestLightsDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.RequestLightsDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003DDC RID: 15836 RVA: 0x000BF024 File Offset: 0x000BD224
			[CallerCount(0)]
			public unsafe void Invoke(Il2CppReferenceArray<Light> requests, Unity.Collections.NativeArray<LightDataGI> lightsOutput)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(requests);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lightsOutput));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.RequestLightsDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003DDD RID: 15837 RVA: 0x0001684D File Offset: 0x00014A4D
			public RequestLightsDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003DDE RID: 15838 RVA: 0x00016856 File Offset: 0x00014A56
			public static implicit operator Lightmapping.RequestLightsDelegate(Action<Il2CppReferenceArray<Light>, Unity.Collections.NativeArray<LightDataGI>> A_0)
			{
				return DelegateSupport.ConvertDelegate<Lightmapping.RequestLightsDelegate>(A_0);
			}

			// Token: 0x06003DDF RID: 15839 RVA: 0x0001685E File Offset: 0x00014A5E
			public static Lightmapping.RequestLightsDelegate operator +(Lightmapping.RequestLightsDelegate A_0, Lightmapping.RequestLightsDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Lightmapping.RequestLightsDelegate>();
			}

			// Token: 0x06003DE0 RID: 15840 RVA: 0x0001686C File Offset: 0x00014A6C
			public static Lightmapping.RequestLightsDelegate operator -(Lightmapping.RequestLightsDelegate A_0, Lightmapping.RequestLightsDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Lightmapping.RequestLightsDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04002D51 RID: 11601
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002D52 RID: 11602
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0;
		}

		// Token: 0x02000A60 RID: 2656
		[ObfuscatedName("UnityEngine.Experimental.GlobalIllumination.Lightmapping+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003DE1 RID: 15841 RVA: 0x000BF080 File Offset: 0x000BD280
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr);
				Lightmapping.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr, "<>9");
				Lightmapping.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr, 100668620);
				Lightmapping.__c.NativeMethodInfoPtr___cctor_b__7_0_Internal_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr, 100668621);
			}

			// Token: 0x06003DE2 RID: 15842 RVA: 0x000BF0E8 File Offset: 0x000BD2E8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003DE3 RID: 15843 RVA: 0x000BF124 File Offset: 0x000BD324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686118, XrefRangeEnd = 686136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__7_0(Il2CppReferenceArray<Light> requests, Unity.Collections.NativeArray<LightDataGI> lightsOutput)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(requests);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lightsOutput));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.__c.NativeMethodInfoPtr___cctor_b__7_0_Internal_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003DE4 RID: 15844 RVA: 0x0001687D File Offset: 0x00014A7D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A40 RID: 2624
			// (get) Token: 0x06003DE5 RID: 15845 RVA: 0x000BF180 File Offset: 0x000BD380
			// (set) Token: 0x06003DE6 RID: 15846 RVA: 0x00016886 File Offset: 0x00014A86
			public unsafe static Lightmapping.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Lightmapping.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lightmapping.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Lightmapping.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D53 RID: 11603
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002D54 RID: 11604
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D55 RID: 11605
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__7_0_Internal_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0;
		}

		// Token: 0x02000A61 RID: 2657
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
