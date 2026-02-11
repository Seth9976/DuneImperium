using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace lib.src.match.voodoo.kabbage
{
	// Token: 0x0200000E RID: 14
	public class GenericFXLocator : MonoBehaviour
	{
		// Token: 0x06000069 RID: 105 RVA: 0x0000A474 File Offset: 0x00008674
		// Note: this type is marked as 'beforefieldinit'.
		static GenericFXLocator()
		{
			Il2CppClassPointerStore<GenericFXLocator>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lib.src.match.voodoo.kabbage", "GenericFXLocator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericFXLocator>.NativeClassPtr);
			GenericFXLocator.NativeFieldInfoPtr_kabbageLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFXLocator>.NativeClassPtr, "kabbageLocations");
			GenericFXLocator.NativeFieldInfoPtr_fxLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFXLocator>.NativeClassPtr, "fxLocations");
			GenericFXLocator.NativeFieldInfoPtr_blockingFXLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFXLocator>.NativeClassPtr, "blockingFXLocations");
			GenericFXLocator.NativeMethodInfoPtr_GetFXTransform_Public_Virtual_New_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFXLocator>.NativeClassPtr, 100663342);
			GenericFXLocator.NativeMethodInfoPtr_TryPlayFX_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFXLocator>.NativeClassPtr, 100663343);
			GenericFXLocator.NativeMethodInfoPtr_TryPlayBlockingFX_Public_Virtual_Final_New_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFXLocator>.NativeClassPtr, 100663344);
			GenericFXLocator.NativeMethodInfoPtr_RegisterWithFXLocator_Public_Void_FXAnimatorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFXLocator>.NativeClassPtr, 100663345);
			GenericFXLocator.NativeMethodInfoPtr_RegisterWithFXLocator_Public_Void_KabbageAnchorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFXLocator>.NativeClassPtr, 100663346);
			GenericFXLocator.NativeMethodInfoPtr_RegisterWithFXLocator_Public_Void_BlockingFXInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFXLocator>.NativeClassPtr, 100663347);
			GenericFXLocator.NativeMethodInfoPtr_DeregisterWithFXLocator_Public_Void_FXAnimatorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFXLocator>.NativeClassPtr, 100663348);
			GenericFXLocator.NativeMethodInfoPtr_DeregisterWithFXLocator_Public_Void_KabbageAnchorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFXLocator>.NativeClassPtr, 100663349);
			GenericFXLocator.NativeMethodInfoPtr_DeregisterWithFXLocator_Public_Void_BlockingFXInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFXLocator>.NativeClassPtr, 100663350);
			GenericFXLocator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFXLocator>.NativeClassPtr, 100663351);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000A5A8 File Offset: 0x000087A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106720, XrefRangeEnd = 1106729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Transform GetFXTransform(string fxName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fxName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericFXLocator.NativeMethodInfoPtr_GetFXTransform_Public_Virtual_New_Transform_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000A604 File Offset: 0x00008804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106729, XrefRangeEnd = 1106739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TryPlayFX(string fxName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fxName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericFXLocator.NativeMethodInfoPtr_TryPlayFX_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000A648 File Offset: 0x00008848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106739, XrefRangeEnd = 1106745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator TryPlayBlockingFX(string fxName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fxName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericFXLocator.NativeMethodInfoPtr_TryPlayBlockingFX_Public_Virtual_Final_New_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000A698 File Offset: 0x00008898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106745, XrefRangeEnd = 1106748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterWithFXLocator(FXAnimatorInfo fxInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(fxInfo));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericFXLocator.NativeMethodInfoPtr_RegisterWithFXLocator_Public_Void_FXAnimatorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000A6E0 File Offset: 0x000088E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106748, XrefRangeEnd = 1106751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterWithFXLocator(KabbageAnchorInfo fxInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(fxInfo));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericFXLocator.NativeMethodInfoPtr_RegisterWithFXLocator_Public_Void_KabbageAnchorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000A728 File Offset: 0x00008928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106751, XrefRangeEnd = 1106754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterWithFXLocator(BlockingFXInfo fxInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(fxInfo));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericFXLocator.NativeMethodInfoPtr_RegisterWithFXLocator_Public_Void_BlockingFXInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000A770 File Offset: 0x00008970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106754, XrefRangeEnd = 1106758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeregisterWithFXLocator(FXAnimatorInfo fxInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(fxInfo));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericFXLocator.NativeMethodInfoPtr_DeregisterWithFXLocator_Public_Void_FXAnimatorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000A7B8 File Offset: 0x000089B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106758, XrefRangeEnd = 1106762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeregisterWithFXLocator(KabbageAnchorInfo fxInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(fxInfo));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericFXLocator.NativeMethodInfoPtr_DeregisterWithFXLocator_Public_Void_KabbageAnchorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000A800 File Offset: 0x00008A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106762, XrefRangeEnd = 1106766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeregisterWithFXLocator(BlockingFXInfo fxInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(fxInfo));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericFXLocator.NativeMethodInfoPtr_DeregisterWithFXLocator_Public_Void_BlockingFXInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000A848 File Offset: 0x00008A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106766, XrefRangeEnd = 1106788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericFXLocator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericFXLocator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericFXLocator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002472 File Offset: 0x00000672
		public GenericFXLocator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000075 RID: 117 RVA: 0x0000A884 File Offset: 0x00008A84
		// (set) Token: 0x06000076 RID: 118 RVA: 0x0000247B File Offset: 0x0000067B
		public unsafe Dictionary<string, KabbageAnchorInfo> kabbageLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFXLocator.NativeFieldInfoPtr_kabbageLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, KabbageAnchorInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFXLocator.NativeFieldInfoPtr_kabbageLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000077 RID: 119 RVA: 0x0000A8B4 File Offset: 0x00008AB4
		// (set) Token: 0x06000078 RID: 120 RVA: 0x0000249A File Offset: 0x0000069A
		public unsafe Dictionary<string, FXAnimatorInfo> fxLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFXLocator.NativeFieldInfoPtr_fxLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, FXAnimatorInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFXLocator.NativeFieldInfoPtr_fxLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000079 RID: 121 RVA: 0x0000A8E4 File Offset: 0x00008AE4
		// (set) Token: 0x0600007A RID: 122 RVA: 0x000024B9 File Offset: 0x000006B9
		public unsafe Dictionary<string, BlockingFXInfo> blockingFXLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFXLocator.NativeFieldInfoPtr_blockingFXLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, BlockingFXInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFXLocator.NativeFieldInfoPtr_blockingFXLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_kabbageLocations;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_fxLocations;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_blockingFXLocations;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_GetFXTransform_Public_Virtual_New_Transform_String_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_TryPlayFX_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_TryPlayBlockingFX_Public_Virtual_Final_New_IEnumerator_String_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_RegisterWithFXLocator_Public_Void_FXAnimatorInfo_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_RegisterWithFXLocator_Public_Void_KabbageAnchorInfo_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_RegisterWithFXLocator_Public_Void_BlockingFXInfo_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterWithFXLocator_Public_Void_FXAnimatorInfo_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterWithFXLocator_Public_Void_KabbageAnchorInfo_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterWithFXLocator_Public_Void_BlockingFXInfo_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000B3 RID: 179
		[ObfuscatedName("lib.src.match.voodoo.kabbage.GenericFXLocator+<TryPlayBlockingFX>d__5")]
		public sealed class _TryPlayBlockingFX_d__5 : global::Il2CppSystem.Object
		{
			// Token: 0x06000A0C RID: 2572 RVA: 0x0002AB14 File Offset: 0x00028D14
			// Note: this type is marked as 'beforefieldinit'.
			static _TryPlayBlockingFX_d__5()
			{
				Il2CppClassPointerStore<GenericFXLocator._TryPlayBlockingFX_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericFXLocator>.NativeClassPtr, "<TryPlayBlockingFX>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericFXLocator._TryPlayBlockingFX_d__5>.NativeClassPtr);
				GenericFXLocator._TryPlayBlockingFX_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFXLocator._TryPlayBlockingFX_d__5>.NativeClassPtr, "<>1__state");
				GenericFXLocator._TryPlayBlockingFX_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFXLocator._TryPlayBlockingFX_d__5>.NativeClassPtr, "<>2__current");
				GenericFXLocator._TryPlayBlockingFX_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFXLocator._TryPlayBlockingFX_d__5>.NativeClassPtr, "<>4__this");
				GenericFXLocator._TryPlayBlockingFX_d__5.NativeFieldInfoPtr_fxName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFXLocator._TryPlayBlockingFX_d__5>.NativeClassPtr, "fxName");
				GenericFXLocator._TryPlayBlockingFX_d__5.NativeFieldInfoPtr__run_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFXLocator._TryPlayBlockingFX_d__5>.NativeClassPtr, "<run>5__2");
				GenericFXLocator._TryPlayBlockingFX_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFXLocator._TryPlayBlockingFX_d__5>.NativeClassPtr, 100663352);
				GenericFXLocator._TryPlayBlockingFX_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFXLocator._TryPlayBlockingFX_d__5>.NativeClassPtr, 100663353);
				GenericFXLocator._TryPlayBlockingFX_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFXLocator._TryPlayBlockingFX_d__5>.NativeClassPtr, 100663354);
				GenericFXLocator._TryPlayBlockingFX_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFXLocator._TryPlayBlockingFX_d__5>.NativeClassPtr, 100663355);
				GenericFXLocator._TryPlayBlockingFX_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFXLocator._TryPlayBlockingFX_d__5>.NativeClassPtr, 100663356);
				GenericFXLocator._TryPlayBlockingFX_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFXLocator._TryPlayBlockingFX_d__5>.NativeClassPtr, 100663357);
			}

			// Token: 0x06000A0D RID: 2573 RVA: 0x0002AC1C File Offset: 0x00028E1C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TryPlayBlockingFX_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericFXLocator._TryPlayBlockingFX_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericFXLocator._TryPlayBlockingFX_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000A0E RID: 2574 RVA: 0x0002AC64 File Offset: 0x00028E64
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericFXLocator._TryPlayBlockingFX_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000A0F RID: 2575 RVA: 0x0002AC98 File Offset: 0x00028E98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106699, XrefRangeEnd = 1106715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericFXLocator._TryPlayBlockingFX_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170002EB RID: 747
			// (get) Token: 0x06000A10 RID: 2576 RVA: 0x0002ACD4 File Offset: 0x00028ED4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericFXLocator._TryPlayBlockingFX_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000A11 RID: 2577 RVA: 0x0002AD14 File Offset: 0x00028F14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106715, XrefRangeEnd = 1106720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericFXLocator._TryPlayBlockingFX_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170002EC RID: 748
			// (get) Token: 0x06000A12 RID: 2578 RVA: 0x0002AD48 File Offset: 0x00028F48
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericFXLocator._TryPlayBlockingFX_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000A13 RID: 2579 RVA: 0x00006E60 File Offset: 0x00005060
			public _TryPlayBlockingFX_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002E6 RID: 742
			// (get) Token: 0x06000A14 RID: 2580 RVA: 0x0002AD88 File Offset: 0x00028F88
			// (set) Token: 0x06000A15 RID: 2581 RVA: 0x00006E69 File Offset: 0x00005069
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFXLocator._TryPlayBlockingFX_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFXLocator._TryPlayBlockingFX_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170002E7 RID: 743
			// (get) Token: 0x06000A16 RID: 2582 RVA: 0x0002ADB0 File Offset: 0x00028FB0
			// (set) Token: 0x06000A17 RID: 2583 RVA: 0x00006E84 File Offset: 0x00005084
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFXLocator._TryPlayBlockingFX_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFXLocator._TryPlayBlockingFX_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002E8 RID: 744
			// (get) Token: 0x06000A18 RID: 2584 RVA: 0x0002ADE0 File Offset: 0x00028FE0
			// (set) Token: 0x06000A19 RID: 2585 RVA: 0x00006EA3 File Offset: 0x000050A3
			public unsafe GenericFXLocator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFXLocator._TryPlayBlockingFX_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericFXLocator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFXLocator._TryPlayBlockingFX_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002E9 RID: 745
			// (get) Token: 0x06000A1A RID: 2586 RVA: 0x0002AE10 File Offset: 0x00029010
			// (set) Token: 0x06000A1B RID: 2587 RVA: 0x00006EC2 File Offset: 0x000050C2
			public unsafe string fxName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFXLocator._TryPlayBlockingFX_d__5.NativeFieldInfoPtr_fxName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFXLocator._TryPlayBlockingFX_d__5.NativeFieldInfoPtr_fxName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170002EA RID: 746
			// (get) Token: 0x06000A1C RID: 2588 RVA: 0x0002AE38 File Offset: 0x00029038
			// (set) Token: 0x06000A1D RID: 2589 RVA: 0x00006EE1 File Offset: 0x000050E1
			public unsafe IEnumerator _run_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFXLocator._TryPlayBlockingFX_d__5.NativeFieldInfoPtr__run_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFXLocator._TryPlayBlockingFX_d__5.NativeFieldInfoPtr__run_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400063D RID: 1597
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400063E RID: 1598
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400063F RID: 1599
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000640 RID: 1600
			private static readonly IntPtr NativeFieldInfoPtr_fxName;

			// Token: 0x04000641 RID: 1601
			private static readonly IntPtr NativeFieldInfoPtr__run_5__2;

			// Token: 0x04000642 RID: 1602
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000643 RID: 1603
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000644 RID: 1604
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000645 RID: 1605
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000646 RID: 1606
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000647 RID: 1607
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
