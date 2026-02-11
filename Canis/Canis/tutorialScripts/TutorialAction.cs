using System;
using System.Runtime.InteropServices;
using Canis.attributes;
using Canis.context;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Canis.tutorialScripts
{
	// Token: 0x0200003D RID: 61
	public class TutorialAction : ObjectAttributes
	{
		// Token: 0x060003AA RID: 938 RVA: 0x000282E4 File Offset: 0x000264E4
		// Note: this type is marked as 'beforefieldinit'.
		static TutorialAction()
		{
			Il2CppClassPointerStore<TutorialAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.tutorialScripts", "TutorialAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialAction>.NativeClassPtr);
			TutorialAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialAction>.NativeClassPtr, 100664109);
			TutorialAction.NativeMethodInfoPtr_AddEntity_Public_TutorialAction_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialAction>.NativeClassPtr, 100664110);
			TutorialAction.NativeMethodInfoPtr_AddEntities_Public_TutorialAction_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialAction>.NativeClassPtr, 100664111);
			TutorialAction.NativeMethodInfoPtr_AddTutorialDisabledAction_Public_TutorialAction_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialAction>.NativeClassPtr, 100664112);
			TutorialAction.NativeMethodInfoPtr_AddViewLayer_Public_TutorialAction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialAction>.NativeClassPtr, 100664113);
			TutorialAction.NativeMethodInfoPtr_AddVFXTag_Public_TutorialAction_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialAction>.NativeClassPtr, 100664114);
			TutorialAction.NativeMethodInfoPtr_AddVFXTags_Public_TutorialAction_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialAction>.NativeClassPtr, 100664115);
			TutorialAction.NativeMethodInfoPtr_ShowForSeconds_Public_TutorialAction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialAction>.NativeClassPtr, 100664116);
			TutorialAction.NativeMethodInfoPtr_ShowForMilliseconds_Public_TutorialAction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialAction>.NativeClassPtr, 100664117);
			TutorialAction.NativeMethodInfoPtr_AfterSeconds_Public_TutorialAction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialAction>.NativeClassPtr, 100664118);
			TutorialAction.NativeMethodInfoPtr_AfterMilliseconds_Public_TutorialAction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialAction>.NativeClassPtr, 100664119);
			TutorialAction.NativeMethodInfoPtr_AddDescription_Public_TutorialAction_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialAction>.NativeClassPtr, 100664120);
			TutorialAction.NativeMethodInfoPtr_AddPlatformVFXTag_Public_TutorialAction_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialAction>.NativeClassPtr, 100664121);
			TutorialAction.NativeMethodInfoPtr_MakeSerializableAttributes_Public_Virtual_New_SerializableAttributes_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialAction>.NativeClassPtr, 100664122);
			TutorialAction.NativeMethodInfoPtr_Has_Public_TutorialAction_AttributeDefinition_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialAction>.NativeClassPtr, 100664123);
			TutorialAction.NativeMethodInfoPtr__ctor_Private_Void_SerializableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialAction>.NativeClassPtr, 100664124);
			TutorialAction.NativeMethodInfoPtr_FromSerializedAttributes_Public_Static_TutorialAction_SerializableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialAction>.NativeClassPtr, 100664125);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00028468 File Offset: 0x00026668
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 551414, RefRangeEnd = 551415, XrefRangeStart = 551413, XrefRangeEnd = 551414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x000284A4 File Offset: 0x000266A4
		[CallerCount(58)]
		[CachedScanResults(RefRangeStart = 551422, RefRangeEnd = 551480, XrefRangeStart = 551415, XrefRangeEnd = 551422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialAction AddEntity(Entity entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialAction.NativeMethodInfoPtr_AddEntity_Public_TutorialAction_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
			}
		}

		// Token: 0x060003AD RID: 941 RVA: 0x000284F4 File Offset: 0x000266F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 551480, XrefRangeEnd = 551508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialAction AddEntities(Il2CppReferenceArray<Entity> entities)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entities);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialAction.NativeMethodInfoPtr_AddEntities_Public_TutorialAction_Il2CppReferenceArray_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
			}
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00028544 File Offset: 0x00026744
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 551532, RefRangeEnd = 551533, XrefRangeStart = 551508, XrefRangeEnd = 551532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialAction AddTutorialDisabledAction(string disabledAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(disabledAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialAction.NativeMethodInfoPtr_AddTutorialDisabledAction_Public_TutorialAction_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
			}
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00028594 File Offset: 0x00026794
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 551543, RefRangeEnd = 551568, XrefRangeStart = 551533, XrefRangeEnd = 551543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialAction AddViewLayer(int layer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialAction.NativeMethodInfoPtr_AddViewLayer_Public_TutorialAction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x000285E0 File Offset: 0x000267E0
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 551592, RefRangeEnd = 551812, XrefRangeStart = 551568, XrefRangeEnd = 551592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialAction AddVFXTag(string vfxTag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(vfxTag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialAction.NativeMethodInfoPtr_AddVFXTag_Public_TutorialAction_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
			}
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00028630 File Offset: 0x00026830
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 551842, RefRangeEnd = 551855, XrefRangeStart = 551812, XrefRangeEnd = 551842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialAction AddVFXTags([Optional] Il2CppStringArray vfxTags)
		{
			if (vfxTags == null)
			{
				vfxTags = new Il2CppStringArray(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vfxTags);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialAction.NativeMethodInfoPtr_AddVFXTags_Public_TutorialAction_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
			}
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00028690 File Offset: 0x00026890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 551855, XrefRangeEnd = 551865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialAction ShowForSeconds(int seconds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref seconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialAction.NativeMethodInfoPtr_ShowForSeconds_Public_TutorialAction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
			}
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x000286DC File Offset: 0x000268DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 551865, XrefRangeEnd = 551875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialAction ShowForMilliseconds(int millis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millis;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialAction.NativeMethodInfoPtr_ShowForMilliseconds_Public_TutorialAction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00028728 File Offset: 0x00026928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 551875, XrefRangeEnd = 551885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialAction AfterSeconds(int seconds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref seconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialAction.NativeMethodInfoPtr_AfterSeconds_Public_TutorialAction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00028774 File Offset: 0x00026974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 551885, XrefRangeEnd = 551895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialAction AfterMilliseconds(int millis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millis;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialAction.NativeMethodInfoPtr_AfterMilliseconds_Public_TutorialAction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
			}
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x000287C0 File Offset: 0x000269C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 551895, XrefRangeEnd = 551906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialAction AddDescription(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialAction.NativeMethodInfoPtr_AddDescription_Public_TutorialAction_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
			}
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00028810 File Offset: 0x00026A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 551906, XrefRangeEnd = 551942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialAction AddPlatformVFXTag(string platform, string vfxTag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(platform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(vfxTag);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialAction.NativeMethodInfoPtr_AddPlatformVFXTag_Public_TutorialAction_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00028874 File Offset: 0x00026A74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 551943, RefRangeEnd = 551944, XrefRangeStart = 551942, XrefRangeEnd = 551943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SerializableAttributes MakeSerializableAttributes(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialAction.NativeMethodInfoPtr_MakeSerializableAttributes_Public_Virtual_New_SerializableAttributes_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x000288D0 File Offset: 0x00026AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 551944, XrefRangeEnd = 551946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe TutorialAction Has<T>(AttributeDefinition<T> attribute, T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TutorialAction.MethodInfoStoreGeneric_Has_Public_TutorialAction_AttributeDefinition_1_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr4) : null;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00028968 File Offset: 0x00026B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 551946, XrefRangeEnd = 551947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialAction(SerializableAttributes serializableAttributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialAction>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializableAttributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialAction.NativeMethodInfoPtr__ctor_Private_Void_SerializableAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x000289B4 File Offset: 0x00026BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 551947, XrefRangeEnd = 551951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TutorialAction FromSerializedAttributes(SerializableAttributes serializableAttributes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializableAttributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialAction.NativeMethodInfoPtr_FromSerializedAttributes_Public_Static_TutorialAction_SerializableAttributes_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TutorialAction>(intPtr3) : null;
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00003970 File Offset: 0x00001B70
		public TutorialAction AddVFXTags(params string[] vfxTags)
		{
			return this.AddVFXTags(new Il2CppStringArray(vfxTags));
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0000397E File Offset: 0x00001B7E
		public TutorialAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_AddEntity_Public_TutorialAction_Entity_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr_AddEntities_Public_TutorialAction_Il2CppReferenceArray_1_Entity_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr_AddTutorialDisabledAction_Public_TutorialAction_String_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr_AddViewLayer_Public_TutorialAction_Int32_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr_AddVFXTag_Public_TutorialAction_String_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_AddVFXTags_Public_TutorialAction_Il2CppStringArray_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_ShowForSeconds_Public_TutorialAction_Int32_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_ShowForMilliseconds_Public_TutorialAction_Int32_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_AfterSeconds_Public_TutorialAction_Int32_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_AfterMilliseconds_Public_TutorialAction_Int32_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_AddDescription_Public_TutorialAction_String_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr_AddPlatformVFXTag_Public_TutorialAction_String_String_0;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializableAttributes_Public_Virtual_New_SerializableAttributes_Context_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_Has_Public_TutorialAction_AttributeDefinition_1_T_T_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializableAttributes_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr_FromSerializedAttributes_Public_Static_TutorialAction_SerializableAttributes_0;

		// Token: 0x0200028E RID: 654
		[ObfuscatedName("Canis.tutorialScripts.TutorialAction+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001BDA RID: 7130 RVA: 0x00085834 File Offset: 0x00083A34
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TutorialAction.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialAction>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialAction.__c>.NativeClassPtr);
				TutorialAction.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialAction.__c>.NativeClassPtr, "<>9");
				TutorialAction.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialAction.__c>.NativeClassPtr, "<>9__2_0");
				TutorialAction.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialAction.__c>.NativeClassPtr, 100664127);
				TutorialAction.__c.NativeMethodInfoPtr__AddEntities_b__2_0_Internal_EntityID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialAction.__c>.NativeClassPtr, 100664128);
			}

			// Token: 0x06001BDB RID: 7131 RVA: 0x000858B0 File Offset: 0x00083AB0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialAction.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialAction.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BDC RID: 7132 RVA: 0x000858EC File Offset: 0x00083AEC
			[CallerCount(0)]
			public unsafe EntityID _AddEntities_b__2_0(Entity entity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialAction.__c.NativeMethodInfoPtr__AddEntities_b__2_0_Internal_EntityID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06001BDD RID: 7133 RVA: 0x0000D4D7 File Offset: 0x0000B6D7
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000665 RID: 1637
			// (get) Token: 0x06001BDE RID: 7134 RVA: 0x0008593C File Offset: 0x00083B3C
			// (set) Token: 0x06001BDF RID: 7135 RVA: 0x0000D4E0 File Offset: 0x0000B6E0
			public unsafe static TutorialAction.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TutorialAction.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialAction.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TutorialAction.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000666 RID: 1638
			// (get) Token: 0x06001BE0 RID: 7136 RVA: 0x00085964 File Offset: 0x00083B64
			// (set) Token: 0x06001BE1 RID: 7137 RVA: 0x0000D4F2 File Offset: 0x0000B6F2
			public unsafe static Func<Entity, EntityID> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TutorialAction.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TutorialAction.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011C4 RID: 4548
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040011C5 RID: 4549
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x040011C6 RID: 4550
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011C7 RID: 4551
			private static readonly IntPtr NativeMethodInfoPtr__AddEntities_b__2_0_Internal_EntityID_Entity_0;
		}

		// Token: 0x0200028F RID: 655
		private sealed class MethodInfoStoreGeneric_Has_Public_TutorialAction_AttributeDefinition_1_T_T_0<T>
		{
			// Token: 0x040011C8 RID: 4552
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TutorialAction.NativeMethodInfoPtr_Has_Public_TutorialAction_AttributeDefinition_1_T_T_0, Il2CppClassPointerStore<TutorialAction>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
