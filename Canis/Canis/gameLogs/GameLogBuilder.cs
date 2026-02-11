using System;
using System.Runtime.InteropServices;
using Canis.attributes;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.gameLogs
{
	// Token: 0x0200009D RID: 157
	[Serializable]
	public class GameLogBuilder : Object
	{
		// Token: 0x060007AD RID: 1965 RVA: 0x000387F0 File Offset: 0x000369F0
		// Note: this type is marked as 'beforefieldinit'.
		static GameLogBuilder()
		{
			Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.gameLogs", "GameLogBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr);
			GameLogBuilder.NativeFieldInfoPtr_LogToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr, "LogToken");
			GameLogBuilder.NativeFieldInfoPtr_LogVars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr, "LogVars");
			GameLogBuilder.NativeFieldInfoPtr_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr, "Parent");
			GameLogBuilder.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr, "Attributes");
			GameLogBuilder.NativeMethodInfoPtr_get_TextVariables_Public_get_TextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr, 100664863);
			GameLogBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr, 100664864);
			GameLogBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr, 100664865);
			GameLogBuilder.NativeMethodInfoPtr__ctor_Public_Void_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr, 100664866);
			GameLogBuilder.NativeMethodInfoPtr__ctor_Public_Void_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr, 100664867);
			GameLogBuilder.NativeMethodInfoPtr_UnwrapKey_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr, 100664868);
			GameLogBuilder.NativeMethodInfoPtr_GetParentLog_Public_SerializedGameLog_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr, 100664869);
			GameLogBuilder.NativeMethodInfoPtr_CopyVars_Public_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr, 100664870);
			GameLogBuilder.NativeMethodInfoPtr_CopyAttributes_Public_GameLogBuilder_IEnumerable_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr, 100664871);
			GameLogBuilder.NativeMethodInfoPtr_CopyAttributes_Public_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr, 100664872);
			GameLogBuilder.NativeMethodInfoPtr_Reset_Public_GameLogBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr, 100664873);
			GameLogBuilder.NativeMethodInfoPtr_WithTextVar_Public_GameLogBuilder_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr, 100664874);
			GameLogBuilder.NativeMethodInfoPtr_AppendTextVar_Public_GameLogBuilder_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr, 100664875);
			GameLogBuilder.NativeMethodInfoPtr_UpsertVarAmount_Public_GameLogBuilder_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr, 100664876);
			GameLogBuilder.NativeMethodInfoPtr_MakeLog_Public_SerializedGameLog_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr, 100664877);
			GameLogBuilder.NativeMethodInfoPtr_Method_Internal_Static_String_byref___c__DisplayClass17_0_byref___c__DisplayClass17_1_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr, 100664878);
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x000389B0 File Offset: 0x00036BB0
		public unsafe TextVariables TextVariables
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 558163, RefRangeEnd = 558165, XrefRangeStart = 558103, XrefRangeEnd = 558163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogBuilder.NativeMethodInfoPtr_get_TextVariables_Public_get_TextVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextVariables>(intPtr3) : null;
			}
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x000389F0 File Offset: 0x00036BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558165, XrefRangeEnd = 558181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameLogBuilder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00038A2C File Offset: 0x00036C2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 558198, RefRangeEnd = 558200, XrefRangeStart = 558181, XrefRangeEnd = 558198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameLogBuilder(string logToken, SerializedGameLog parent = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(logToken);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00038A8C File Offset: 0x00036C8C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 558241, RefRangeEnd = 558245, XrefRangeStart = 558200, XrefRangeEnd = 558241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameLogBuilder(GameLogBuilder original)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogBuilder.NativeMethodInfoPtr__ctor_Public_Void_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00038AD8 File Offset: 0x00036CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558245, XrefRangeEnd = 558336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameLogBuilder(SerializedGameLog serializedLog)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedLog);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogBuilder.NativeMethodInfoPtr__ctor_Public_Void_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00038B24 File Offset: 0x00036D24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 558347, RefRangeEnd = 558350, XrefRangeStart = 558336, XrefRangeEnd = 558347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string UnwrapKey(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogBuilder.NativeMethodInfoPtr_UnwrapKey_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00038B6C File Offset: 0x00036D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558350, XrefRangeEnd = 558355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedGameLog GetParentLog(IHasGameLogs hgl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hgl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogBuilder.NativeMethodInfoPtr_GetParentLog_Public_SerializedGameLog_IHasGameLogs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr3) : null;
			}
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00038BBC File Offset: 0x00036DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558355, XrefRangeEnd = 558397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameLogBuilder CopyVars(GameLogBuilder other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogBuilder.NativeMethodInfoPtr_CopyVars_Public_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00038C0C File Offset: 0x00036E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558397, XrefRangeEnd = 558398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameLogBuilder CopyAttributes(IEnumerable<IAttribute> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogBuilder.NativeMethodInfoPtr_CopyAttributes_Public_GameLogBuilder_IEnumerable_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00038C5C File Offset: 0x00036E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558398, XrefRangeEnd = 558399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameLogBuilder CopyAttributes(GameLogBuilder other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogBuilder.NativeMethodInfoPtr_CopyAttributes_Public_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00038CAC File Offset: 0x00036EAC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 558425, RefRangeEnd = 558430, XrefRangeStart = 558399, XrefRangeEnd = 558425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameLogBuilder Reset(string newLogToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newLogToken);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogBuilder.NativeMethodInfoPtr_Reset_Public_GameLogBuilder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00038CFC File Offset: 0x00036EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558430, XrefRangeEnd = 558433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameLogBuilder WithTextVar(string key, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogBuilder.NativeMethodInfoPtr_WithTextVar_Public_GameLogBuilder_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00038D60 File Offset: 0x00036F60
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 558456, RefRangeEnd = 558478, XrefRangeStart = 558433, XrefRangeEnd = 558456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameLogBuilder AppendTextVar(string key, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogBuilder.NativeMethodInfoPtr_AppendTextVar_Public_GameLogBuilder_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00038DC4 File Offset: 0x00036FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558478, XrefRangeEnd = 558492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameLogBuilder UpsertVarAmount(string key, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogBuilder.NativeMethodInfoPtr_UpsertVarAmount_Public_GameLogBuilder_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00038E24 File Offset: 0x00037024
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 558514, RefRangeEnd = 558515, XrefRangeStart = 558492, XrefRangeEnd = 558514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedGameLog MakeLog(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogBuilder.NativeMethodInfoPtr_MakeLog_Public_SerializedGameLog_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr3) : null;
			}
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00038E70 File Offset: 0x00037070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558515, XrefRangeEnd = 558521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Method_Internal_Static_String_byref___c__DisplayClass17_0_byref___c__DisplayClass17_1_PDM_0(ref GameLogBuilder.__c__DisplayClass17_0 A_0, ref GameLogBuilder.__c__DisplayClass17_1 A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogBuilder.NativeMethodInfoPtr_Method_Internal_Static_String_byref___c__DisplayClass17_0_byref___c__DisplayClass17_1_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00004FC8 File Offset: 0x000031C8
		public GameLogBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x00038EBC File Offset: 0x000370BC
		// (set) Token: 0x060007C0 RID: 1984 RVA: 0x00004FD1 File Offset: 0x000031D1
		public unsafe string LogToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogBuilder.NativeFieldInfoPtr_LogToken);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogBuilder.NativeFieldInfoPtr_LogToken), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x00038EE4 File Offset: 0x000370E4
		// (set) Token: 0x060007C2 RID: 1986 RVA: 0x00004FF0 File Offset: 0x000031F0
		public unsafe Dictionary<string, Object> LogVars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogBuilder.NativeFieldInfoPtr_LogVars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogBuilder.NativeFieldInfoPtr_LogVars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x00038F14 File Offset: 0x00037114
		// (set) Token: 0x060007C4 RID: 1988 RVA: 0x0000500F File Offset: 0x0000320F
		public Nullable<int> Parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogBuilder.NativeFieldInfoPtr_Parent);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogBuilder.NativeFieldInfoPtr_Parent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x00038F44 File Offset: 0x00037144
		// (set) Token: 0x060007C6 RID: 1990 RVA: 0x0000503D File Offset: 0x0000323D
		public unsafe MutableAttributes Attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogBuilder.NativeFieldInfoPtr_Attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogBuilder.NativeFieldInfoPtr_Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeFieldInfoPtr_LogToken;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeFieldInfoPtr_LogVars;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeFieldInfoPtr_Parent;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeFieldInfoPtr_Attributes;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeMethodInfoPtr_get_TextVariables_Public_get_TextVariables_0;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_SerializedGameLog_0;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameLogBuilder_0;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedGameLog_0;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeMethodInfoPtr_UnwrapKey_Private_String_String_0;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeMethodInfoPtr_GetParentLog_Public_SerializedGameLog_IHasGameLogs_0;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeMethodInfoPtr_CopyVars_Public_GameLogBuilder_GameLogBuilder_0;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeMethodInfoPtr_CopyAttributes_Public_GameLogBuilder_IEnumerable_1_IAttribute_0;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeMethodInfoPtr_CopyAttributes_Public_GameLogBuilder_GameLogBuilder_0;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_GameLogBuilder_String_0;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeMethodInfoPtr_WithTextVar_Public_GameLogBuilder_String_Object_0;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeMethodInfoPtr_AppendTextVar_Public_GameLogBuilder_String_Object_0;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeMethodInfoPtr_UpsertVarAmount_Public_GameLogBuilder_String_Int32_0;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeMethodInfoPtr_MakeLog_Public_SerializedGameLog_Int32_0;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_byref___c__DisplayClass17_0_byref___c__DisplayClass17_1_PDM_0;

		// Token: 0x020002DE RID: 734
		[ObfuscatedName("Canis.gameLogs.GameLogBuilder+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001EB4 RID: 7860 RVA: 0x0008E5BC File Offset: 0x0008C7BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GameLogBuilder.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLogBuilder.__c>.NativeClassPtr);
				GameLogBuilder.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogBuilder.__c>.NativeClassPtr, "<>9");
				GameLogBuilder.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogBuilder.__c>.NativeClassPtr, "<>9__8_0");
				GameLogBuilder.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogBuilder.__c>.NativeClassPtr, "<>9__8_1");
				GameLogBuilder.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogBuilder.__c>.NativeClassPtr, 100664880);
				GameLogBuilder.__c.NativeMethodInfoPtr___ctor_b__8_0_Internal_String_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogBuilder.__c>.NativeClassPtr, 100664881);
				GameLogBuilder.__c.NativeMethodInfoPtr___ctor_b__8_1_Internal_Object_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogBuilder.__c>.NativeClassPtr, 100664882);
			}

			// Token: 0x06001EB5 RID: 7861 RVA: 0x0008E660 File Offset: 0x0008C860
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameLogBuilder.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogBuilder.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EB6 RID: 7862 RVA: 0x0008E69C File Offset: 0x0008C89C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558101, XrefRangeEnd = 558102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string __ctor_b__8_0(KeyValuePair<string, Object> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogBuilder.__c.NativeMethodInfoPtr___ctor_b__8_0_Internal_String_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001EB7 RID: 7863 RVA: 0x0008E6EC File Offset: 0x0008C8EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558102, XrefRangeEnd = 558103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object __ctor_b__8_1(KeyValuePair<string, Object> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogBuilder.__c.NativeMethodInfoPtr___ctor_b__8_1_Internal_Object_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001EB8 RID: 7864 RVA: 0x0000EBEB File Offset: 0x0000CDEB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000730 RID: 1840
			// (get) Token: 0x06001EB9 RID: 7865 RVA: 0x0008E744 File Offset: 0x0008C944
			// (set) Token: 0x06001EBA RID: 7866 RVA: 0x0000EBF4 File Offset: 0x0000CDF4
			public unsafe static GameLogBuilder.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameLogBuilder.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameLogBuilder.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameLogBuilder.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000731 RID: 1841
			// (get) Token: 0x06001EBB RID: 7867 RVA: 0x0008E76C File Offset: 0x0008C96C
			// (set) Token: 0x06001EBC RID: 7868 RVA: 0x0000EC06 File Offset: 0x0000CE06
			public unsafe static Func<KeyValuePair<string, Object>, string> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameLogBuilder.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, Object>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameLogBuilder.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000732 RID: 1842
			// (get) Token: 0x06001EBD RID: 7869 RVA: 0x0008E794 File Offset: 0x0008C994
			// (set) Token: 0x06001EBE RID: 7870 RVA: 0x0000EC18 File Offset: 0x0000CE18
			public unsafe static Func<KeyValuePair<string, Object>, Object> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameLogBuilder.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, Object>, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameLogBuilder.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001368 RID: 4968
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001369 RID: 4969
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x0400136A RID: 4970
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x0400136B RID: 4971
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400136C RID: 4972
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__8_0_Internal_String_KeyValuePair_2_String_Object_0;

			// Token: 0x0400136D RID: 4973
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__8_1_Internal_Object_KeyValuePair_2_String_Object_0;
		}

		// Token: 0x020002DF RID: 735
		[ObfuscatedName("Canis.gameLogs.GameLogBuilder+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : ValueType
		{
			// Token: 0x06001EBF RID: 7871 RVA: 0x0000EC2A File Offset: 0x0000CE2A
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<GameLogBuilder.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLogBuilder.__c__DisplayClass17_0>.NativeClassPtr);
				GameLogBuilder.__c__DisplayClass17_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogBuilder.__c__DisplayClass17_0>.NativeClassPtr, "key");
			}

			// Token: 0x06001EC0 RID: 7872 RVA: 0x0000EC5E File Offset: 0x0000CE5E
			public __c__DisplayClass17_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001EC1 RID: 7873 RVA: 0x0000EC67 File Offset: 0x0000CE67
			public __c__DisplayClass17_0()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameLogBuilder.__c__DisplayClass17_0>.NativeClassPtr))
			{
			}

			// Token: 0x17000733 RID: 1843
			// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x0008E7BC File Offset: 0x0008C9BC
			// (set) Token: 0x06001EC3 RID: 7875 RVA: 0x0000EC79 File Offset: 0x0000CE79
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogBuilder.__c__DisplayClass17_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogBuilder.__c__DisplayClass17_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400136E RID: 4974
			private static readonly IntPtr NativeFieldInfoPtr_key;
		}

		// Token: 0x020002E0 RID: 736
		[ObfuscatedName("Canis.gameLogs.GameLogBuilder+<>c__DisplayClass17_1")]
		[StructLayout(2)]
		public struct __c__DisplayClass17_1
		{
			// Token: 0x06001EC4 RID: 7876 RVA: 0x0000EC98 File Offset: 0x0000CE98
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_1()
			{
				Il2CppClassPointerStore<GameLogBuilder.__c__DisplayClass17_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameLogBuilder>.NativeClassPtr, "<>c__DisplayClass17_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLogBuilder.__c__DisplayClass17_1>.NativeClassPtr);
				GameLogBuilder.__c__DisplayClass17_1.NativeFieldInfoPtr_suffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogBuilder.__c__DisplayClass17_1>.NativeClassPtr, "suffix");
			}

			// Token: 0x06001EC5 RID: 7877 RVA: 0x0000ECCC File Offset: 0x0000CECC
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameLogBuilder.__c__DisplayClass17_1>.NativeClassPtr, ref this));
			}

			// Token: 0x0400136F RID: 4975
			private static readonly IntPtr NativeFieldInfoPtr_suffix;

			// Token: 0x04001370 RID: 4976
			[FieldOffset(0)]
			public int suffix;
		}
	}
}
